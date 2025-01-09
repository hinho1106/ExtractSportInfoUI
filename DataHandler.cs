using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInfoUI
{
    public static class DataHandler
    {
        

        public static async Task<List<SportInfo>> processSportInput(string sport, string week, string day, string exAge, string exWord, string sportType)
        {
            //General variables
            bool controlFlag = true;
            List<SportInfo> infoTable = new List<SportInfo>();
            string[] exAges = exAge.Split(';');
            string[] exWords = exWord.Split(";");

            //Define Sport Type boolean control
            bool isIce = false;
            if (sportType.Equals("Ice"))
                isIce = true;

            string generalResponse;

            if(isIce)
                generalResponse = await HTTPHandler.GETIceSportGeneralResponse();
            else
                generalResponse = await HTTPHandler.GETNonIceSportGeneralResponse();

            RootObj rootObj;

            //Convert response to JSON format
            try
            {
                rootObj = JsonConvert.DeserializeObject<RootObj>(generalResponse);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return infoTable;
            }

            foreach (var venue in rootObj.features)
            {
                List<string?> sportCat = new List<string?>();
                string? venueName;
                int id = venue.attributes.locationid == null? 0 : (int)venue.attributes.locationid;

                if (isIce)
                {
                    sportCat.Add(venue.attributes.activity_type);
                    venueName = venue.attributes.location;
                }
                else
                {
                    sportCat.Add(venue.attributes.sports_activities_a_d);
                    sportCat.Add(venue.attributes.sports_activities_e_p);
                    sportCat.Add(venue.attributes.sports_activities_s_z);
                    venueName = venue.attributes.complexname;
                }
                


                foreach(string? sportlist in sportCat)
                {
                    if (!string.IsNullOrEmpty(sportlist) ? sportlist.Contains(sport) : false)
                    {

                        string info;
                        
                        if (isIce)
                            info = await HTTPHandler.GETIceSportInfo(id, week);
                        else
                            info = await HTTPHandler.GETNonIceSportInfo(id, week);
                        

                        RootPrograms? infoObj;

                        //Convert response to JSON format
                        try
                        {
                            infoObj = JsonConvert.DeserializeObject<RootPrograms>(info);
                            if (infoObj == null)
                            {
                                continue;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return infoTable;
                        }


                        try
                        {

                            List<Day>? programs = infoObj.programs[0].days;
                            foreach (Day program in programs)
                            {
                                //Set up controlFlag
                                controlFlag = program.title.Contains(sport);
                                if (!exAge.Equals(""))
                                    foreach (string age in exAges)
                                    {
                                        controlFlag &= !program.age.Contains(age);
                                    }
                                if (!exWord.Equals(""))
                                    foreach (string word in exWords)
                                    {
                                        controlFlag &= !program.title.Contains(word);
                                    }

                                if (controlFlag)
                                {

                                    foreach (Time time in program.times)
                                    {
                                        if (time.day.Contains(day))
                                        {
                                            //commCentre, sportName, weekday, time
                                            infoTable.Add(new SportInfo()
                                            {
                                                venue = venueName,
                                                sport = program.title + " " + program.age,
                                                day = time.day,
                                                time = time.title
                                            });
                                            //Console.WriteLine(program.title);


                                            //Console.WriteLine(time.day + "\t" + time.title);
                                        }


                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return new List<SportInfo>();
                        }

                    }
                }
                



            }

            return infoTable;
        }

        
    }
}

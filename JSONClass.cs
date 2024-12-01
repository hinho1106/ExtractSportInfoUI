using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportInfoUI
{
    //JSON format for macro info
    public class RootObj
    {
        public string? objectIdFieldName { get; set; }
        public UniqueIdField? uniqueIdField { get; set; }
        public string? globalIdFieldName { get; set; }
        public string? geometryType { get; set; }
        public SpatialReference? spatialReference { get; set; }
        public List<Field>? fields { get; set; }
        public List<Feature>? features { get; set; }
    }

    public class Attributes
    {
        public int objectid_1 { get; set; }
        public int? objectid { get; set; }
        public int locationid { get; set; }
        public int facility_master_id { get; set; }
        public string? complexname { get; set; }
        public string? address { get; set; }
        public string? website { get; set; }
        public string? location_type { get; set; }
        public string? show_on_sports_map { get; set; }
        public string? sports_activities_a_d { get; set; }
        public string? sports_activities_e_p { get; set; }
        public string? sports_activities_s_z { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public string? globalid { get; set; }
    }

    public class Feature
    {
        public Attributes? attributes { get; set; }
        public Geometry? geometry { get; set; }
    }

    public class Field
    {
        public string? name { get; set; }
        public string? type { get; set; }
        public string? alias { get; set; }
        public string? sqlType { get; set; }
        public object? domain { get; set; }
        public object? defaultValue { get; set; }
        public int? length { get; set; }
    }

    public class Geometry
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    public class SpatialReference
    {
        public int wkid { get; set; }
        public int latestWkid { get; set; }
    }

    public class UniqueIdField
    {
        public string? name { get; set; }
        public bool? isSystemMaintained { get; set; }
    }

    //JSON format for particular sport info of a comm centre
    public class Day
    {
        public int id { get; set; }
        public string? day { get; set; }
        public string? title { get; set; }
        public string? age { get; set; }
        public string? status { get; set; }
        public string? comment { get; set; }
        public string? link { get; set; }
        public List<Time>? times { get; set; }
    }

    public class Program
    {
        public string? program { get; set; }
        public List<Day>? days { get; set; }
    }

    public class RootPrograms
    {
        public List<Program>? programs { get; set; }
    }

    public class Time
    {
        public string? id { get; set; }
        public string? day { get; set; }
        public string? title { get; set; }
        public string? status { get; set; }
        public string? comment { get; set; }
        public string? link { get; set; }
    }
}

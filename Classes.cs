interface ClassInfo
{
    string Class_name {get; set;}
    string Class_no {get; set;}
}
class Classes : ClassInfo
{
    public string classname;
    public string no_class;
    public string Class_name
    {
        get {return classname; }
        set {classname = value;}
    }
    public string Class_no
    {
        get {return no_class;}
        set {no_class = value;}
    }
}
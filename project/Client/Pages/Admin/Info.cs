public class ListElements{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Url { get; set; }
    public string Date { get; set; }
}

public class TitleCount{
    public string? Title { get; set; }
    public int Count { get; set; }
    public int Rate { get; set; } // 0 - 100
    public bool IsPositive {get; set;}
}

public class InitializeData{
    public InitializeData(){
        var elements = new List<ListElements>{
            new ListElements{Id = 1, Name = "M-100001", Url = "machine1", Date = DateTime.Now.ToString("dd-mm-yy")},
            new ListElements{Id = 2, Name = "M-100002", Url = "machine2", Date = DateTime.Now.ToString("dd-mm-yy")},
            new ListElements{Id = 3, Name = "M-100003", Url = "machine3", Date = DateTime.Now.ToString("dd-mm-yy")},
            new ListElements{Id = 4, Name = "M-100004", Url = "machine4", Date = DateTime.Now.ToString("dd-mm-yy")},
            new ListElements{Id = 5, Name = "M-100005", Url = "machine5", Date = DateTime.Now.ToString("dd-mm-yy")}
        };

        var titleElements = new List<TitleCount>{
            new TitleCount{Title = "Users", Count = 2500, Rate = 4, IsPositive = true},
            new TitleCount{Title = "Avarage Time", Count = 123, Rate = 3, IsPositive = true},
            new TitleCount{Title = "Males", Count = 2500, Rate = 34, IsPositive = true},
            new TitleCount{Title = "Females", Count = 4567, Rate = 12, IsPositive = false},
            new TitleCount{Title = "Collections", Count = 2315, Rate = 34, IsPositive = true},
            new TitleCount{Title = "Connections", Count = 7325, Rate = 34, IsPositive = true}
        };

        listElements.AddRange(elements);
        listTitleCount.AddRange(titleElements);
    }
    public List<ListElements> listElements {get; set;} = new List<ListElements>();
    public List<TitleCount> listTitleCount {get; set;} = new List<TitleCount>();
}
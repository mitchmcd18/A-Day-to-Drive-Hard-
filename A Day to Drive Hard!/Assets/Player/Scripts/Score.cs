﻿using SQLite4Unity3d;

public class Score  {

    [PrimaryKey, AutoIncrement]
    public int scoreID{ get; set; }
    public string time { get; set; }
    public string date { get; set; }
    public int distance { get; set; }
    public int score { get; set; }


}

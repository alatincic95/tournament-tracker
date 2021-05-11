﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TrackerLibrary.DataAccess1;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PersonModels.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";

        public static IDataConnection Connection { get; private set; } 

        public static void InitializeConnections(DataBaseType db)
        {
            if (db==DataBaseType.Sql) // ne mora se stavit (database == true) zato sto je bool
            {
                // TODO - Set up the SQL Connector properly.
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            else if (db==DataBaseType.TextFile)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppKeyLookup(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
        
    }
}

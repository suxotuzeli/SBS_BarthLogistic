using System.Data;

namespace SBS_BarthLogistic.Classes.Database
{
    public class Procedure
    {
        public Procedure(string routineName, string routineSchema) //, string routineDefinition)
        {
            RoutineName = routineName;
            //RoutineDefinition = routineDefinition;
            RoutineSchema = routineSchema;
        }

        public string RoutineName { get; set; }
        public string RoutineSchema { get; set; }

        public string GetRoutineDefinition()
        {
            var dtSp = SQL.Select("exec sp_helptext '" + RoutineName + "'");
            if (dtSp.Rows.Count <= 0) return string.Empty;
            var routineDefinition = string.Empty;
            var replaced = false;
            foreach (DataRow row in dtSp.Rows)
            {
                var line = row[0].ToString();
                if (!replaced && line.Contains("CREATE"))
                {
                    line = line.Replace("CREATE", "ALTER");
                    replaced = true;
                }
                routineDefinition += line;
            }
            return routineDefinition.TrimStart();
        }
    }
}
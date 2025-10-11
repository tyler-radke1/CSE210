using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GoalManagerData
{
    public int Score { get; set; }
    public List<Goal> Goals { get; set; }
}

public class GoalJsonConverter : System.Text.Json.Serialization.JsonConverter<Goal>
{
    public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (var doc = JsonDocument.ParseValue(ref reader))
        {
            var jsonObject = doc.RootElement;

            string type = jsonObject.GetProperty("Type").GetString();

            switch (type)
            {
                case "SimpleGoal":
                    return JsonSerializer.Deserialize<SimpleGoal>(jsonObject.GetRawText(), options);
                case "EternalGoal":
                    return JsonSerializer.Deserialize<EternalGoal>(jsonObject.GetRawText(), options);
                case "ChecklistGoal":
                    return JsonSerializer.Deserialize<ChecklistGoal>(jsonObject.GetRawText(), options);
                default:
                    throw new NotSupportedException($"Unknown goal type: {type}");
            }
        }
    }

    public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case SimpleGoal sg:
                JsonSerializer.Serialize(writer, sg, options);
                break;
            case EternalGoal eg:
                JsonSerializer.Serialize(writer, eg, options);
                break;
            case ChecklistGoal cg:
                JsonSerializer.Serialize(writer, cg, options);
                break;
        }
    }
}

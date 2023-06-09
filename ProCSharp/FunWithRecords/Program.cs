using FunWithRecords;

AnotherCarRecord carRecord = new AnotherCarRecord("Honda", "Pilot", "Blue");
carRecord.Deconstruct(out string make1, out string model1, out string color1);
var (make, model, color) = carRecord;

var carRecord1 = carRecord with{ Model = "Odyssye" };
Console.WriteLine(carRecord);
Console.WriteLine(carRecord1);
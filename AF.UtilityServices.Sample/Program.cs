using Architecture.Foundation.UtilityServices;
using AF.UtilityServices.Sample;


//Encrypt/Decrypt string without salt key
var orgValueWithOutSalt = "Architecture Foundation";
var encryptVal = AFUtility.UtilityService.Encrypt(orgValueWithOutSalt);
var decryptVal = AFUtility.UtilityService.Dycrypt(encryptVal);
//end

//Encrypt/Decrypt string with salt key
var orgValueWithSalt= "Architecture Foundation";
var encryptValWithSalt = AFUtility.UtilityService.Encrypt(orgValueWithSalt, "F123wjt&");
var decryptValWithSalt = AFUtility.UtilityService.Dycrypt(encryptValWithSalt, "F123wjt&");
//end

//Map object
var mainObject = new EmployeeEntity() { EmployeeID = Guid.NewGuid(), Name = "Architecture Foundation", Address = "India", Phone = "9999999999", Salary = 10.10 };

var targetObject = new MirrorEmployeeEntity();
AFUtility.UtilityService.MapObjects(mainObject, targetObject);
//end

//Serialize/Deserialize object
var obj = new EmployeeEntity() { EmployeeID = Guid.NewGuid(), Name = "Architecture Foundation", Address = "India", Phone = "9999999999", Salary = 10.10 };
var xmlserializedObj = AFUtility.UtilityService.Serialized(obj);
var DeserializedObj = AFUtility.UtilityService.Deserialized<EmployeeEntity>(xmlserializedObj);

Console.WriteLine("Original value to encrypt without SALT: " + orgValueWithOutSalt);
Console.WriteLine("Encrypted value: " + encryptVal);
Console.WriteLine("Decrypted value: " + decryptVal);
Console.WriteLine();

Console.WriteLine("Original value to encrypt with SALT: " + orgValueWithSalt);
Console.WriteLine("Encrypted value: " + encryptValWithSalt);
Console.WriteLine("Decrypted value: " + decryptValWithSalt);
Console.WriteLine();

Console.WriteLine("Object copy");
Console.WriteLine("===========");
Console.WriteLine("Name:" + targetObject.Name);
Console.WriteLine("Name:" + targetObject.Address);
Console.WriteLine("Name:" + targetObject.Phone);
Console.WriteLine("Name:" + targetObject.Salary);
Console.WriteLine();

Console.WriteLine("Class Serialize/Deserialize");
Console.WriteLine("===========================");
Console.WriteLine("Serialize value: "+ xmlserializedObj);
Console.WriteLine("Deserialize object: " + DeserializedObj.GetType().Name);
Console.WriteLine();

Console.WriteLine("Press any key to exit");
Console.ReadKey();

//end
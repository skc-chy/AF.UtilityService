using Architecture.Foundation.UtilityServices;
using AF.UtilityServices.Sample;


//Encrypt/Decrypt string without salt key
var encryptVal = AFUtility.UtilityService.Encrypt("Architecture Foundation");
var decryptVal = AFUtility.UtilityService.Dycrypt(encryptVal);
//end

//Encrypt/Decrypt string with salt key
var encryptValWithSalt = AFUtility.UtilityService.Encrypt("Architecture Foundation", "F123wjt&");
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
//end
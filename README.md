# TestJsonSerialization
Output: 

```
---------
A - Json with $type

{
  "$type": "TestJsonSerialization.SmsSentEvent, TestJsonSerialization",
  "SmsId": "ad6480cc-da69-4e90-a06c-4fd4621831b5",
  "Text": "10/18/2022",
  "Number": "638017116024831315"
}
Deserialized type is 'TestJsonSerialization.SmsSentEvent'
---------
B - Json without $type

{
  "SmsId": "ad6480cc-da69-4e90-a06c-4fd4621831b5",
  "Text": "10/18/2022",
  "Number": "638017116024831315"
}
Deserialized type is 'Newtonsoft.Json.Linq.JObject'
---------
```

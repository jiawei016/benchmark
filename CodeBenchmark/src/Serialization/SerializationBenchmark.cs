using BenchmarkDotNet.Attributes;
using CodeBenchmark.src.Serialization.Models;
using FastSerialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CodeBenchmark.src.Serialization
{
    [InProcessAttribute]
    [MemoryDiagnoser]
    public class SerializationBenchmark
    {
        string jsonString = @"{
	        'id': '5cf72414b97023feed70111c',
	        'index': 0,
	        'guid': 'c57d7018-5f87-4f79-a8ac-9e29b6b8f2d2',
	        'isActive': false,
	        'balance': '$3,998.67',
	        'picture': 'http://placehold.it/32x32',
	        'age': 36,
	        'eyeColor': 'green',
	        'name': {
		        'first': 'York',
		        'last': 'Bonner'
	        },
	        'company': 'SAVVY',
	        'email': 'york.bonner@savvy.biz',
	        'phone': '+1 (833) 529-2011',
	        'address': '693 Duffield Street, Moraida, Wisconsin, 1658',
	        'about': 'Occaecat tempor id ad culpa anim. Eiusmod sit commodo exercitation occaecat dolor commodo ullamco velit. Fugiat mollit esse id proident.',
	        'latitude': '-10.211243',
	        'longitude': '-15.700221',
	        'friends': [
		        {
			        'id': 0,
			        'name': 'Dodson Knox'
		        },
		        {
			        'id': 1,
			        'name': 'Kendra Wilder'
		        },
		        {
			        'id': 2,
			        'name': 'Jocelyn Knowles'
		        }
	        ],
	        'greeting': 'Hello, York! You have 10 unread messages.',
	        'favoriteFruit': 'apple'
        }";

        [Params(1000)]
        public int N;

        [Benchmark]
        public void JsonToJObjectTest()
        {
            for (int i = 0; i < N; i++)
            {
                var json = JObject.Parse(jsonString);

                var id = json["id"];
                var index = json["index"];
                var guid = json["guid"];
                var isActive = json["isActive"];
                var balance = json["balance"];
                var picture = json["picture"];
                var age = json["age"];
                var eyeColor = json["eyeColor"];
                var name = json["name"];
                var firstName = name["first"];
                var lastName = name["last"];
                var company = json["company"];
                var email = json["email"];
                var phone = json["phone"];
                var address = json["address"];
                var about = json["about"];
                var latitude = json["latitude"];
                var longitude = json["longitude"];
                var greeting = json["greeting"];
                var favoriteFruit = json["favoriteFruit"];

                var infoString = json.ToString();
            }
        }

        [Benchmark(Baseline = true)]
        public void JsonToObjectTest()
        {
            for (int i = 0; i < N; i++)
            {
                var parsedObject = JsonConvert.DeserializeObject<Info>(jsonString);
                var id = parsedObject.id;
                var index = parsedObject.index;
                var guid = parsedObject.guid;
                var isActive = parsedObject.isActive;
                var balance = parsedObject.balance;
                var picture = parsedObject.picture;
                var age = parsedObject.age;
                var eyeColor = parsedObject.eyeColor;
                var name = parsedObject.name;
                var firstName = name.first;
                var lastName = name.last;
                var company = parsedObject.company;
                var email = parsedObject.email;
                var phone = parsedObject.phone;
                var address = parsedObject.address;
                var about = parsedObject.about;
                var latitude = parsedObject.latitude;
                var longitude = parsedObject.longitude;
                var greeting = parsedObject.greeting;
                var favoriteFruit = parsedObject.favoriteFruit;

                var infoString = JsonConvert.SerializeObject(parsedObject);
            }
        }

        [Benchmark]
        public void JsonToJsonSerializerTest()
        {
            JsonSerializer serializer = new JsonSerializer();
            for (int i = 0; i < N; i++)
            {
                using (StreamWriter sw = new StreamWriter(jsonString))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    Info info;
                    info = System.Text.Json.JsonSerializer.Deserialize<Info>(jsonString);
                    var id = info.id;
                    var index = info.index;
                    var guid = info.guid;
                    var isActive = info.isActive;
                    var balance = info.balance;
                    var picture = info.picture;
                    var age = info.age;
                    var eyeColor = info.eyeColor;
                    var name = info.name;
                    var firstName = name.first;
                    var lastName = name.last;
                    var company = info.company;
                    var email = info.email;
                    var phone = info.phone;
                    var address = info.address;
                    var about = info.about;
                    var latitude = info.latitude;
                    var longitude = info.longitude;
                    var greeting = info.greeting;
                    var favoriteFruit = info.favoriteFruit;

                    serializer.Serialize(writer, info);
                }            }
        }
    }
}

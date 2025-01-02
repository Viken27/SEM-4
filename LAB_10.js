//Part-A
//1
db.Student.updateOne({name:"John"},{$set:{age:31}})
//2
db.Student.updateMany({city:"New York"},{$set:{city:"New Jersey"}})
//3
db.Student.updateMany({age : {$gt:35}},{$set:{isActive:”false”}})
//4
db.Student.updateMany({},{$inc:{age:1}})
//5
db.Student.updateMany({name:"Eva"},{$set:{name:"Cambridge"}})
//6
db.Student.updateMany({name:'Sophia'},{$set:{isActive:”false”}})
//7
db.Student.updateMany({age:{$lt:30}},{$set:{city:'San Diego'}})
//8
db.Student.updateMany({},{$rename:{age:'years'}})
//9
db.Student.updateMany({name:'Nick'},{$set:{isActive:”true”}})
//10
db.Student.updateMany({},{$set:{country:'USA'}})
//11
db.Student.updateMany({name:'David'},{$set:{city:'Orlando'}})
//12
db.Student.updateMany({},{$mul:{years:2}})
//13
db.Student.updateMany({name:'Tom'},{$unset:{city:""}})
//14
db.Student.updateMany({years:{$gt:30}},{$set:{premiumUser:”true”}})
//15
db.Student.updateMany({name:'Jane'},{$set:{isActive:”true”}})
//16
db.Student.updateMany({name:'Lucy'},{$set:{isActive:”false”}})
//17
db.Student.deleteOne({name:'Nick'})
//18
db.Student.deleteMany({isActive:”false”})
//19
db.Student.deleteMany({city:'New York'})
//20
db.Student.deleteMany({years:{$gt:35}})
//21
db.Student.deleteMany({name:'Olivia'})
//22
db.Student.deleteMany({years:{$lt:25}})
//23
db.Student.deleteOne({isActive:”true”})
//24
db.Student.deleteMany({city:'Los Angeles'})
//25
db.Student.deleteMany({city: {$exists:” false”}})
//26
db.Student.updateMany({},{$rename:{city:'location'}})
//27
db.Student.updateMany({name:'John'},{$rename:{name:'Fullname'}})
//28
db.Student.updateMany({},{$rename:{isActive:'status'}})
//29
db.Student.updateMany({city:'San Francisco'},{$rename:{age:'yearsOld'}})
//30
db.createCollection('Employee', {
    capped: true,
    size: 5120,
    max: 100,
    validator: {
        $jsonSchema: {
            bsonType: 'object',
            required: ['Ecode', 'Ename'],
            properties: {
                Ecode: {
                    bsonType: 'int',
                    description: 'Ecode must be a int and is required'
                },
                Ename: {
                    bsonType: 'string',
                    description: 'Ename must be an string and is required'
                },
                Age: {
                    bsonType: 'int',
                    description: 'Age must be a int and is required'
                },
                City: {
                    bsonType: 'string',
                    description: 'City must be an string and is required'
                }
            }
        }
    }
})

db.Employee.insertMany([
    { Ecode: 1, Ename: 'John' },
    { Ecode: 2, Ename: 'Jane', Age: 25, City: 'Los Angeles' },
    { Ecode: 3, Ename: 'Tom', Age: 35 },
    { Ecode: 4, Ename: 'Lucy', Age: 28, City: 'San Francisco', isActive: true },
    { Ecode: 5, Ename: 'Dino', Age: 40, City: '' },
])

//Part-B
db.createCollection("Student_data")
db.Student_data.insertMany([{
    "ROLLNO": 101,
    "SNAME": "Vina",
    "DEPARTMENT": "CE",
    "FEES": 15000,
    "SEM": 3,
    "GENDER": "Female",
    "CITY": "Rajkot"
  },
  {
    "ROLLNO": 102,
    "SNAME": "Krisha",
    "DEPARTMENT": "EC",
    "FEES": 8000,
    "SEM": 5,
    "GENDER": "Female",
    "CITY": "Ahmedabad"
  },
  {
    "ROLLNO": 103,
    "SNAME": "Priti",
    "DEPARTMENT": "Civil",
    "FEES": 12000,
    "SEM": 7,
    "GENDER": "Female",
    "CITY": "Baroda"
  },
  {
    "ROLLNO": 104,
    "SNAME": "Mitul",
    "DEPARTMENT": "CE",
    "FEES": 15000,
    "SEM": 3,
    "GENDER": "Male",
    "CITY": "Rajkot"
  },
  {
    "ROLLNO": 105,
    "SNAME": "Keshav",
    "DEPARTMENT": "CE",
    "FEES": 15000,
    "SEM": 3,
    "GENDER": "Male",
    "CITY": "Jamnagar"
  },
  {
    "ROLLNO": 106,
    "SNAME": "Zarna",
    "DEPARTMENT": "Civil",
    "FEES": 12000,
    "SEM": 5,
    "GENDER": "Female",
    "CITY": "Ahmedabad"
  },
  {
    "ROLLNO": 107,
    "SNAME": "Nima",
    "DEPARTMENT": "EE",
    "FEES": 9000,
    "SEM": 5,
    "GENDER": "Female",
    "CITY": "Rajkot"
  },
  {
    "ROLLNO": 108,
    "SNAME": "Dhruv",
    "DEPARTMENT": "Mechanical",
    "FEES": 10000,
    "SEM": 5,
    "GENDER": "Male",
    "CITY": "Rajkot"
  },
  {
    "ROLLNO": 109,
    "SNAME": "Krish",
    "DEPARTMENT": "Mechanical",
    "FEES": 10000,
    "SEM": 7,
    "GENDER": "Male",
    "CITY": "Baroda"
  },
  {
    "ROLLNO": 110,
    "SNAME": "Zeel",
    "DEPARTMENT": "EE",
    "FEES": 9000,
    "SEM": 3,
    "GENDER": "Female",
    "CITY": "Jamnagar"
  }
])
//1
db.Student_data.find({$and:[{GENDER:'Female'},{CITY:'Rajkot'}]})
//2
db.Student_data.find({SEM:{$ne:3}})
//3
db.Student_data.find({CITY:{$in:['Jamnagar','Baroda']}})
//4
db.Student_data.find({CITY:'Baroda'}).limit(2)
//5
db.Student_data.find({$and:[{GENDER:'Male'},{SEM:3}]})
//6
db.Student_data.find({ROLLNO:{$lt:105}},{SNAME:1,CITY:1,FEES:1,_id:0})
//7
db.Student_data.updateMany({CITY:'Jamnagar',DEPARTMENT:'CE'},{$set:{CITY:'Surat'}})
//8
db.Student_data.updateMany({GENDER:{$not:{$eq:'Female'}}},{$inc:{FEES:500}})
//9
db.Student_data.updateMany({DEPARTMENT:'EE',SEM:3},{$set:{DEPARTMENT:'Electrical'}})
//10
db.Student_data.updateMany({ City: 'Rajkot', Gender: 'Male' },{ $set: { Fees: newFeesAmount } })
//11
db.Student_data.updateMany({SEM:5,FEES:{$lt:10000}},{$set:{CITY:'Vadodara'}})
//12
db.Student_data.deleteMany({$or:[{CITY:'Ahmedabad'},{GENDER:'Male'}]})
//13
db.Student_data.deleteMany({ROLLNO:{$nin:[101,105,110]}})
//14
db.Student_data.deleteMany({Department:'Civil',Sem:{$in:[5,7]}})
//15
db.Student_data.deleteMany({CITY:{$nin:['Rajkot','Baroda','Jamnagar']}})
//16
db.Student_data.deleteMany({ROLLNO:{$gte:105,$lte:108}})
//17
db.Student_data.updateMany({},{$rename:{CITY:'LOCATION'}})
//18
db.Student_data.updateMany({FEES:{$lt:10000}},{$rename:{DEPARTMENT:'Branch'}})
//19
db.Student_data.updateMany({ROLLNO:{$in:[106,107,108]}},{$rename:{SNAME:'FullName'}})
//20
db.Student_data.updateMany({FEES:{$gt:9000}},{$rename:{FEES:'Tuiton_Fees'}})

//21
db.Student_data.updateMany({$and:[{FEES:{$lt:15000}},{GENDER:'Female'}]},{$rename:{DEPARTMENT:'Major'}})
//22
db.Student_data.updateMany({SEM:3,DEPARTMENT:{$ne:'Mechanical'}},{$rename:{CITY:'HomeTown'}})

//Part-C
//1
db.createCollection("logs",{capped:true,size:10240,max:10})
//2
db.logs.insertMany([{ message: "System started", level: "info", timestamp: new Date() }, 
{ message: "Disk space low", level: "warning", timestamp: new Date() }, 
{ message: "User login", level: "info", timestamp: new Date() }, 
{ message: "System reboot", level: "info", timestamp: new Date() }, 
{ message: "Error in module", level: "error", timestamp: new Date() }, 
{ message: "Memory usage high", level: "warning", timestamp: new Date() }, 
{ message: "User logout", level: "info", timestamp: new Date() }, 
{ message: "File uploaded", level: "info", timestamp: new Date() }, 
{ message: "Network error", level: "error", timestamp: new Date() }, 
{ message: "Backup completed", level: "info", timestamp: new Date() }, 
{ message: "Database error", level: "error", timestamp: new Date() }, 
{ message: "Service started", level: "info", timestamp: new Date() } ])
//3
db.logs.find().sort({_id:-1}).limit(12)
//4
db.logs.insertMany([{ message: "New log entry 1", level: "info", timestamp: new Date() }, 
{ message: "New log entry 2", level: "info", timestamp: new Date() }, 
{ message: "New log entry 3", level: "info", timestamp: new Date() }, 
{ message: "New log entry 4", level: "warning", timestamp: new Date() }, 
{ message: "New log entry 5", level: "error", timestamp: new Date() } ])

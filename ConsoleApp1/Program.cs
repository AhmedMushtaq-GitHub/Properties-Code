using ConsoleApp1;

//Long type Property
Student st = new Student();
Console.WriteLine("Please Enter name");//Message to user
st.Name = Console.ReadLine()??"";//saving user input

//Auto type Property
st.Description = ",Your wellcome Our web Site.Tell me do you have experions about csharp";
Console.WriteLine($"\nOk Dear {st.Name} {st.Description}");//Output

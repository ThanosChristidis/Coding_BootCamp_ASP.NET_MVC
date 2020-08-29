namespace Coding_BootCamp.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using Coding_BootCamp.Entities;
    using Coding_BootCamp.Database;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //========================================================== COURSES' SEED ==============================================================================================================================

            Course c1 = new Course() { Title = "C#", Type = "Part Time", Stream = "CB9", StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 6, 10), PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7a/C_Sharp_logo.svg/1200px-C_Sharp_logo.svg.png" };
            Course c2 = new Course() { Title = "Java", Type = "Part Time", Stream = "CB9", StartDate = new DateTime(2020, 1, 6), EndDate = new DateTime(2020, 6, 22), PhotoUrl = "https://pics.imgrapid.com/wp-content/uploads/2019/09/13154906/dbgxt2rvpd26udoyzcqn.0.0.jpg" };
            Course c3 = new Course() { Title = "JavaScript", Type = "Part Time", Stream = "CB9", StartDate = new DateTime(2020, 1, 4), EndDate = new DateTime(2020, 5, 19), PhotoUrl = "https://4.bp.blogspot.com/-1GOghsk3j-k/XF_8G1N735I/AAAAAAAAcsU/vT7r4s-EL3gEDlzsbD4u8yu5VZo8YSuOQCLcBGAs/s1600/js.jpg" };
            Course c4 = new Course() { Title = "Python", Type = "Part Time", Stream = "CB9", StartDate = new DateTime(2020, 1, 23), EndDate = new DateTime(2020, 5, 28), PhotoUrl = "https://i.udemycdn.com/course/750x422/2167996_0e41_3.jpg" };
            Course c5 = new Course() { Title = "SQL", Type = "Part Time", Stream = "CB9", StartDate = new DateTime(2020, 1, 17), EndDate = new DateTime(2020, 6, 1), PhotoUrl = "https://i.pinimg.com/originals/93/93/93/939393f109743ab4b0a4be3efff08163.jpg" };
            Course c6 = new Course() { Title = "HTML", Type = "Part Time", Stream = "CB9", StartDate = new DateTime(2020, 1, 18), EndDate = new DateTime(2020, 6, 1), PhotoUrl = "https://cdn.pixabay.com/photo/2017/08/05/11/16/logo-2582748_960_720.png" };

            //========================================================= STUDENTS' SEED ========================================================================================================================= 

            Student s1 = new Student() { FirstName = "Margarita", LastName = "Anagnostou", DateOfBirth = new DateTime(2001, 9, 7), TelNumber = "6985413369", Email = "ilaherba@gmail.com", Age = 19, PhotoUrl = "https://images.unsplash.com/photo-1580643735948-c52d25d9c07d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1190&q=80" };
            Student s2 = new Student() { FirstName = "Stefanos", LastName = "Gkikas", DateOfBirth = new DateTime(1991, 2, 10), TelNumber = "6985454511", Email = "stephan@hotmail.com", Age = 29, PhotoUrl = "https://images.unsplash.com/photo-1539598492601-581aa9675a30?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" };
            Student s3 = new Student() { FirstName = "Giorgos", LastName = "Gkanos", DateOfBirth = new DateTime(1992, 4, 10), TelNumber = "6985417234", Email = "gkanos@hotmail.com", Age = 27, PhotoUrl = "https://images.unsplash.com/photo-1542156822-6924d1a71ace?ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80" };
            Student s4 = new Student() { FirstName = "Thanos", LastName = "Christidis", DateOfBirth = new DateTime(1991, 4, 22), Email = "thanoschris@gmail.com", TelNumber = "6980571834", PhotoUrl = "https://images.unsplash.com/photo-1562024754-fa14e7d69b7a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=700&q=80" };
            Student s5 = new Student() { FirstName = "Dimitra", LastName = "Arsenopoulou", DateOfBirth = new DateTime(2000, 5, 25), TelNumber = "6985413369", Email = "dimitrarsen@gmail.com", PhotoUrl = "https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" };
            Student s6 = new Student() { FirstName = "Alexandra", LastName = "Psila", DateOfBirth = new DateTime(1994, 6, 1), TelNumber = "6974594185", Email = "psilaalexandra@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1553775564-b2c2752c9e75?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=633&q=80" };
            Student s7 = new Student() { FirstName = "Eleni", LastName = "Dimopoulou", DateOfBirth = new DateTime(1993, 8, 10), TelNumber = "6990448487", Email = "dimop@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1557058450-79f35296f714?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80" };
            Student s8 = new Student() { FirstName = "Marianna", LastName = "Paparizou", DateOfBirth = new DateTime(1992, 2, 12), Email = "mariannapapa@gmail.com", TelNumber = "6971885993", PhotoUrl = "https://images.unsplash.com/photo-1548754144-65873dce8beb?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1051&q=80" };
            Student s9 = new Student() { FirstName = "Andromachi", LastName = "Pappasava", DateOfBirth = new DateTime(2001, 9, 14), TelNumber = "698584267", Email = "andropap@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1531299669378-dd18b44a8dbc?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1047&q=80" };
            Student s10 = new Student() { FirstName = "Georgia", LastName = "Zisi", DateOfBirth = new DateTime(1987, 8, 25), TelNumber = "69549696511", Email = "geozi@gmail.com", Age = 33, PhotoUrl = "https://images.unsplash.com/photo-1517842536804-bf6629e2c291?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80" };
            Student s11 = new Student() { FirstName = "Melina", LastName = "Fasili", DateOfBirth = new DateTime(1995, 10, 13), TelNumber = "698541185", Email = "melinafast@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1544717305-2782549b5136?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" };
            Student s12 = new Student() { FirstName = "Anastasia", LastName = "Christidou", DateOfBirth = new DateTime(1984, 9, 26), TelNumber = "6922578574", Email = "anastchris@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1519650090143-fa886a36f757?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" };
            Student s13 = new Student() { FirstName = "Dionisis", LastName = "Mantzaris", DateOfBirth = new DateTime(1981, 7, 28), TelNumber = "6984988569", Email = "dmantza@hotmail.com", Age = 28, PhotoUrl = "https://images.unsplash.com/photo-1473492201326-7c01dd2e596b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1051&q=80" };
            Student s14 = new Student() { FirstName = "Zacharias", LastName = "Giannopoulos", DateOfBirth = new DateTime(1989, 10, 21), TelNumber = "6985417511", Email = "gianno@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1544168190-79c17527004f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" };
            Student s15 = new Student() { FirstName = "Alexandros", LastName = "Papanikolaou", DateOfBirth = new DateTime(1988, 9, 20), TelNumber = "6985413644", Email = "alexpap@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1506794778202-cad84cf45f1d?ixlib=rb-1.2.1&auto=format&fit=crop&w=634&q=80" };
            Student s16 = new Student() { FirstName = "Christos", LastName = "Gotsis", DateOfBirth = new DateTime(1995, 5, 20), TelNumber = "6951417511", Email = "chrisgotsis@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1530645298377-82c8416d3f90?ixlib=rb-1.2.1&auto=format&fit=crop&w=634&q=80" };
            Student s17 = new Student() { FirstName = "Miltiadis", LastName = "Gotsis", DateOfBirth = new DateTime(1997, 4, 8), Email = "miltkiamos@gmail.com", TelNumber = "6914499657", PhotoUrl = "https://images.unsplash.com/photo-1504593811423-6dd665756598?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80" };
            Student s18 = new Student() { FirstName = "Thanos", LastName = "Foteinos", DateOfBirth = new DateTime(2001, 9, 4), TelNumber = "6940239941", Email = "thanosfoteinos@yahoo.com", PhotoUrl = "https://images.unsplash.com/photo-1521341057461-6eb5f40b07ab?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" };
            Student s19 = new Student() { FirstName = "Antonis", LastName = "Toliadis", DateOfBirth = new DateTime(1999, 10, 13), TelNumber = "698584511", Email = "toliadis@hotmail.com", Age = 29, PhotoUrl = "https://images.unsplash.com/photo-1503430935654-c3847b9289eb?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=668&q=80" };
            Student s20 = new Student() { FirstName = "Aggeliki", LastName = "Xenou", DateOfBirth = new DateTime(1988, 10, 2), TelNumber = "6985417511", Email = "agglikaxenou@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1526160404000-b3f5ec7071a0?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" };
            Student s21 = new Student() { FirstName = "Nefeli", LastName = "Zamani", DateOfBirth = new DateTime(1986, 6, 4), TelNumber = "691489119", Email = "nefeliza@hotmail.com", Age = 26, PhotoUrl = "https://images.unsplash.com/photo-1584544526241-e7ddd926e3a8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=658&q=80" };
            Student s22 = new Student() { FirstName = "Pavlos", LastName = "Zisopoulos", DateOfBirth = new DateTime(2000, 10, 8), TelNumber = "6985454511", Email = "paulzis@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1508908324153-d1a219719814?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80" };
            Student s23 = new Student() { FirstName = "Petros", LastName = "Ferekidis", DateOfBirth = new DateTime(1990, 3, 7), TelNumber = "6985417511", Email = "katkat@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1489980557514-251d61e3eeb6?ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80" };
            Student s24 = new Student() { FirstName = "Konstantinos", LastName = "Dellatolas", DateOfBirth = new DateTime(1996, 6, 11), TelNumber = "696595561", Email = "arguro@yahoo.com", Age = 24, PhotoUrl = "https://images.unsplash.com/photo-1492447273231-0f8fecec1e3a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" };
            Student s25 = new Student() { FirstName = "Anna", LastName = "Kontostamou", DateOfBirth = new DateTime(1993, 6, 27), TelNumber = "6985417511", Email = "mastorissa@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1456885284447-7dd4bb8720bf?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" };
            Student s26 = new Student() { FirstName = "Manos", LastName = "Grigoriou", DateOfBirth = new DateTime(2001, 9, 19), TelNumber = "6985412457", Email = "manosgrigoriou@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1493752603190-08d8b5d1781d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=800&q=80" };
            Student s27 = new Student() { FirstName = "Vasilis", LastName = "Kiasos", DateOfBirth = new DateTime(1987, 1, 16), TelNumber = "69245442", Email = "vaski@hotmail.com", Age = 30, PhotoUrl = "https://images.unsplash.com/photo-1496346236646-50e985b31ea4?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" };
            Student s28 = new Student() { FirstName = "Vasiliki", LastName = "Kalli", DateOfBirth = new DateTime(2000, 6, 29), TelNumber = "69853551741", Email = "vasilikikalli@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1547944409-0c3ef40a5c48?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80" };
            Student s29 = new Student() { FirstName = "Olga", LastName = "Laimou", DateOfBirth = new DateTime(1993, 8, 25), TelNumber = "698545473", Email = "laimolga@hotmail.com", Age = 27, PhotoUrl = "https://images.unsplash.com/photo-1580067275289-045cfe79f473?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=631&q=80" };
            Student s30 = new Student() { FirstName = "Nikoletta", LastName = "Theodorou", DateOfBirth = new DateTime(2001, 9, 23), TelNumber = "6944498887", Email = "nikol@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1549444933-d7c7880322bd?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=675&q=80" };


            //================================================================== TRAINERS' SEED ===========================================================================================================

            StudentCourse sc1 = new StudentCourse() { Student = s1, Course = c5, TuittionFees = 2800, EnrollmentDate = new DateTime(2019, 11, 1) };
            StudentCourse sc2 = new StudentCourse() { Student = s2, Course = c4, CourseGrade = 76, TuittionFees = 2000, EnrollmentDate = new DateTime(2019, 12, 1) };
            StudentCourse sc3 = new StudentCourse() { Student = s1, Course = c2, CourseGrade = 90, EnrollmentDate = new DateTime(2019, 11, 3) };
            StudentCourse sc4 = new StudentCourse() { Student = s2, Course = c3, TuittionFees = 2300.54, EnrollmentDate = new DateTime(2019, 11, 3) };
            StudentCourse sc5 = new StudentCourse() { Student = s10, Course = c6, CourseGrade = 100, EnrollmentDate = new DateTime(2019, 12, 12) };
            StudentCourse sc6 = new StudentCourse() { Student = s3, Course = c1, CourseGrade = 81, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc7 = new StudentCourse() { Student = s3, Course = c6, CourseGrade = 70, TuittionFees = 2500, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc8 = new StudentCourse() { Student = s4, Course = c6, TuittionFees = 1786, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc9 = new StudentCourse() { Student = s15, Course = c6, CourseGrade = 65, TuittionFees = 1532.25, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc10 = new StudentCourse() { Student = s19, Course = c6, CourseGrade = 96, TuittionFees = 2009.64, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc11 = new StudentCourse() { Student = s22, Course = c6, CourseGrade = 79, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc12 = new StudentCourse() { Student = s10, Course = c1, CourseGrade = 94, TuittionFees = 1900, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc13 = new StudentCourse() { Student = s5, Course = c5, TuittionFees = 2500.43, EnrollmentDate = new DateTime(2019, 11, 1) };
            StudentCourse sc14 = new StudentCourse() { Student = s8, Course = c4, CourseGrade = 76, TuittionFees = 2000, EnrollmentDate = new DateTime(2019, 12, 1) };
            StudentCourse sc15 = new StudentCourse() { Student = s6, Course = c2, CourseGrade = 90, EnrollmentDate = new DateTime(2019, 11, 3) };
            StudentCourse sc16 = new StudentCourse() { Student = s7, Course = c3, TuittionFees = 2300.54, EnrollmentDate = new DateTime(2019, 11, 3) };
            StudentCourse sc17 = new StudentCourse() { Student = s27, Course = c3, CourseGrade = 99, EnrollmentDate = new DateTime(2019, 12, 12) };
            StudentCourse sc18 = new StudentCourse() { Student = s11, Course = c1, CourseGrade = 56, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc19 = new StudentCourse() { Student = s12, Course = c2, TuittionFees = 1900, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc20 = new StudentCourse() { Student = s4, Course = c4, CourseGrade = 81, TuittionFees = 1900, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc21 = new StudentCourse() { Student = s15, Course = c5, CourseGrade = 81, TuittionFees = 2100, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc22 = new StudentCourse() { Student = s19, Course = c3, TuittionFees = 1900, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc23 = new StudentCourse() { Student = s22, Course = c1, CourseGrade = 87, TuittionFees = 1900, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc24 = new StudentCourse() { Student = s13, Course = c1, TuittionFees = 1900, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc25 = new StudentCourse() { Student = s29, Course = c5, CourseGrade = 81, TuittionFees = 2100, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc26 = new StudentCourse() { Student = s30, Course = c5, CourseGrade = 88, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc27 = new StudentCourse() { Student = s23, Course = c5, CourseGrade = 93, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc28 = new StudentCourse() { Student = s24, Course = c4, CourseGrade = 76, TuittionFees = 2000, EnrollmentDate = new DateTime(2019, 12, 1) };
            StudentCourse sc29 = new StudentCourse() { Student = s25, Course = c4, TuittionFees = 2000, EnrollmentDate = new DateTime(2019, 12, 1) };
            StudentCourse sc30 = new StudentCourse() { Student = s26, Course = c4, CourseGrade = 76, TuittionFees = 2000, EnrollmentDate = new DateTime(2019, 12, 1) };
            StudentCourse sc31 = new StudentCourse() { Student = s21, Course = c3, TuittionFees = 1900, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc32 = new StudentCourse() { Student = s20, Course = c3, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc33 = new StudentCourse() { Student = s12, Course = c1, CourseGrade = 99, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc34 = new StudentCourse() { Student = s17, Course = c2, TuittionFees = 1965.74, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc35 = new StudentCourse() { Student = s16, Course = c2, TuittionFees = 1687.78, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc36 = new StudentCourse() { Student = s11, Course = c3, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc37 = new StudentCourse() { Student = s17, Course = c1, CourseGrade = 76, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc38 = new StudentCourse() { Student = s14, Course = c1, CourseGrade = 68, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc39 = new StudentCourse() { Student = s9, Course = c2, CourseGrade = 100, TuittionFees = 2300, EnrollmentDate = new DateTime(2019, 12, 9) };
            StudentCourse sc40 = new StudentCourse() { Student = s18, Course = c4, CourseGrade = 100, TuittionFees = 1800.69, EnrollmentDate = new DateTime(2019, 12, 16) };
            StudentCourse sc41 = new StudentCourse() { Student = s26, Course = c3, CourseGrade = 92, EnrollmentDate = new DateTime(2019, 11, 1) };
            StudentCourse sc42 = new StudentCourse() { Student = s28, Course = c2, CourseGrade = 99, EnrollmentDate = new DateTime(2019, 11, 3) };



            Trainer t1 = new Trainer() { FirstName = "Georgia", LastName = "Sotiropoulou", Subject = "Back End Developer", Age = 40, TelNumber = "6941337544", Email = "georgiasalv@gmail.com", PhotoUrl = "https://images.unsplash.com/photo-1551989745-347c28b620e5?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80" };
            Trainer t2 = new Trainer() { FirstName = "Hector", LastName = "Gkatsos", Subject = "Full Stack Developer", Age = 32, TelNumber = "6941337996", Email = "hectorgatsos@gmail.com", PhotoUrl = "https://images.unsplash.com/photo-1564130987042-acbca1b51e8d?ixlib=rb-1.2.1&auto=format&fit=crop&w=666&q=80" };
            Trainer t3 = new Trainer() { FirstName = "Zachos", LastName = "Alexandridis", Subject = "Database Developer", Age = 38, TelNumber = "694254138", Email = "alexval@hotmail.com", PhotoUrl = "https://images.unsplash.com/photo-1559223694-98ed5e272fef?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80" };
            Trainer t4 = new Trainer() { FirstName = "Katerina", LastName = "Makrigianni", Subject = "Web Develiper", Age = 34, TelNumber = "695413674", Email = "nefelimakri@yahoo.com", PhotoUrl = "https://images.unsplash.com/photo-1559921914-33685704cf18?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=640&q=80" };
            Trainer t5 = new Trainer() { FirstName = "Konstantinos", LastName = "Stroggulos", Subject = "Database Developer", Age = 43, TelNumber = "698514966", Email = "koststroggulos@hotmail.com", PhotoUrl = "https://images.unsplash.com/flagged/photo-1557896279-080cb03b9ca6?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80" };

            //================================================================= TRAINERCOURSES' SEED =======================================================================================================

            TrainerCourse tc1 = new TrainerCourse() { Trainer = t1, Course = c2, EnrollmentDate = new DateTime(2018, 6, 14) };
            TrainerCourse tc2 = new TrainerCourse() { Trainer = t1, Course = c1, EnrollmentDate = new DateTime(2018, 9, 15) };
            TrainerCourse tc3 = new TrainerCourse() { Trainer = t2, Course = c1, Salary = 2000, EnrollmentDate = new DateTime(2019, 12, 1), };
            TrainerCourse tc4 = new TrainerCourse() { Trainer = t2, Course = c3, EnrollmentDate = new DateTime(2017, 7, 18), };
            TrainerCourse tc5 = new TrainerCourse() { Trainer = t2, Course = c5, Salary = 950, EnrollmentDate = new DateTime(2016, 11, 27), };
            TrainerCourse tc6 = new TrainerCourse() { Trainer = t2, Course = c6, EnrollmentDate = new DateTime(2019, 10, 3), };
            TrainerCourse tc7 = new TrainerCourse() { Trainer = t3, Course = c5, EnrollmentDate = new DateTime(2019, 5, 6), };
            TrainerCourse tc8 = new TrainerCourse() { Trainer = t3, Course = c2, Salary = 1378, EnrollmentDate = new DateTime(2017, 4, 29), };
            TrainerCourse tc9 = new TrainerCourse() { Trainer = t3, Course = c4, EnrollmentDate = new DateTime(2019, 8, 24), };
            TrainerCourse tc10 = new TrainerCourse() { Trainer = t4, Course = c6, Salary = 968.47, EnrollmentDate = new DateTime(2019, 3, 5), };
            TrainerCourse tc11 = new TrainerCourse() { Trainer = t4, Course = c3, Salary = 1200, EnrollmentDate = new DateTime(2018, 1, 18), };
            TrainerCourse tc12 = new TrainerCourse() { Trainer = t5, Course = c5, Salary = 985.62, EnrollmentDate = new DateTime(2019, 4, 13), };
            TrainerCourse tc13 = new TrainerCourse() { Trainer = t5, Course = c1, EnrollmentDate = new DateTime(2018, 12, 9), };
            TrainerCourse tc14 = new TrainerCourse() { Trainer = t5, Course = c2, Salary = 963, EnrollmentDate = new DateTime(2018, 11, 13), };
            TrainerCourse tc15 = new TrainerCourse() { Trainer = t1, Course = c4, EnrollmentDate = new DateTime(2018, 10, 18), };
            TrainerCourse tc16 = new TrainerCourse() { Trainer = t4, Course = c2, Salary = 1352, EnrollmentDate = new DateTime(2017, 2, 21), };
            TrainerCourse tc17 = new TrainerCourse() { Trainer = t5, Course = c6, Salary = 1125.95, EnrollmentDate = new DateTime(2019, 7, 24), };
            TrainerCourse tc18 = new TrainerCourse() { Trainer = t3, Course = c1, Salary = 1000, EnrollmentDate = new DateTime(2017, 5, 16), };

            //=================================================================== PROJECTS' SEED ============================================================================================================


            Project p1 = new Project() { Title = "Calculator", Description = "", SubDate = new DateTime(2020, 1, 17), PhotoUrl = "#" };
            Project p2 = new Project() { Title = "Tic Tac Toe", Description = "An application for the famous game", SubDate = new DateTime(2020, 2, 14), PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/32/Tic_tac_toe.svg/1200px-Tic_tac_toe.svg.png" };
            Project p3 = new Project() { Title = "Final Project", Description = "E-Shop Structure", SubDate = new DateTime(2020, 4, 16), PhotoUrl = "https://www.forthright.gr/wp-content/uploads/eCommerce-Cycle-1024x508.jpg" };
            Project p4 = new Project() { Title = "Fight Simulation", Description = "", SubDate = new DateTime(2020, 3, 24), PhotoUrl = "#" };
            Project p5 = new Project() { Title = "Credit Card Checker", Description = "", SubDate = new DateTime(2020, 3, 24), PhotoUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcREiPBL196FghUyCtOXDdLjhvDmqQdlxrZgoTgM0TJ4BsyIhIRV&usqp=CAU" };

            //============================================================= PROJECTSTUDENT SEED =============================================================================================

            ProjectStudent ps1 = new ProjectStudent() { Student = s1, Course = c5, Project = p1, EnrollmentDate = new DateTime(2020, 5, 9) };
            ProjectStudent ps2 = new ProjectStudent() { Student = s2, Course = c4, Project = p4, ProjectGrade = 98, EnrollmentDate = new DateTime(2020, 2, 10) };
            ProjectStudent ps3 = new ProjectStudent() { Student = s1, Course = c2, Project = p5, EnrollmentDate = new DateTime(2020, 3, 14) };
            ProjectStudent ps4 = new ProjectStudent() { Student = s1, Course = c5, Project = p4, ProjectGrade = 100, EnrollmentDate = new DateTime(2020, 4, 3) };
            ProjectStudent ps5 = new ProjectStudent() { Student = s2, Course = c3, Project = p3, ProjectGrade = 79, EnrollmentDate = new DateTime(2020, 5, 28) };
            ProjectStudent ps6 = new ProjectStudent() { Student = s10, Course = c6, Project = p3, ProjectGrade = 84, EnrollmentDate = new DateTime(2020, 1, 18) };
            ProjectStudent ps7 = new ProjectStudent() { Student = s3, Course = c1, Project = p2, ProjectGrade = 72, EnrollmentDate = new DateTime(2020, 3, 16) };
            ProjectStudent ps8 = new ProjectStudent() { Student = s4, Course = c6, Project = p5, EnrollmentDate = new DateTime(2020, 5, 17) };
            ProjectStudent ps9 = new ProjectStudent() { Student = s15, Course = c6, Project = p4, EnrollmentDate = new DateTime(2020, 2, 12) };
            ProjectStudent ps10 = new ProjectStudent() { Student = s19, Course = c6, Project = p5, ProjectGrade = 99, EnrollmentDate = new DateTime(2020, 4, 21) };
            ProjectStudent ps11 = new ProjectStudent() { Student = s22, Course = c6, Project = p2, ProjectGrade = 86, EnrollmentDate = new DateTime(2020, 5, 29) };
            ProjectStudent ps12 = new ProjectStudent() { Student = s10, Course = c1, Project = p1, ProjectGrade = 97, EnrollmentDate = new DateTime(2020, 2, 24) };
            ProjectStudent ps13 = new ProjectStudent() { Student = s5, Course = c5, Project = p5, EnrollmentDate = new DateTime(2020, 3, 13) };
            ProjectStudent ps14 = new ProjectStudent() { Student = s8, Course = c4, Project = p3, EnrollmentDate = new DateTime(2020, 2, 19) };
            ProjectStudent ps15 = new ProjectStudent() { Student = s6, Course = c2, Project = p4, ProjectGrade = 73, EnrollmentDate = new DateTime(2020, 4, 17) };
            ProjectStudent ps16 = new ProjectStudent() { Student = s7, Course = c3, Project = p2, ProjectGrade = 94, EnrollmentDate = new DateTime(2020, 5, 19) };
            ProjectStudent ps17 = new ProjectStudent() { Student = s27, Course = c3, Project = p2, ProjectGrade = 90, EnrollmentDate = new DateTime(2020, 2, 23) };
            ProjectStudent ps18 = new ProjectStudent() { Student = s11, Course = c1, Project = p1, EnrollmentDate = new DateTime(2020, 4, 25) };
            ProjectStudent ps19 = new ProjectStudent() { Student = s12, Course = c2, Project = p1, ProjectGrade = 95, EnrollmentDate = new DateTime(2020, 1, 26) };
            ProjectStudent ps20 = new ProjectStudent() { Student = s4, Course = c4, Project = p1, ProjectGrade = 73, EnrollmentDate = new DateTime(2020, 4, 22) };
            ProjectStudent ps21 = new ProjectStudent() { Student = s15, Course = c5, Project = p3, EnrollmentDate = new DateTime(2020, 3, 21) };
            ProjectStudent ps22 = new ProjectStudent() { Student = s19, Course = c3, Project = p3, ProjectGrade = 99, EnrollmentDate = new DateTime(2020, 1, 17) };
            ProjectStudent ps23 = new ProjectStudent() { Student = s22, Course = c1, Project = p4, EnrollmentDate = new DateTime(2020, 3, 18) };
            ProjectStudent ps24 = new ProjectStudent() { Student = s13, Course = c1, Project = p2, ProjectGrade = 76, EnrollmentDate = new DateTime(2020, 2, 16) };
            ProjectStudent ps25 = new ProjectStudent() { Student = s29, Course = c5, Project = p5, ProjectGrade = 62, EnrollmentDate = new DateTime(2020, 1, 2) };
            ProjectStudent ps26 = new ProjectStudent() { Student = s30, Course = c5, Project = p1, ProjectGrade = 87, EnrollmentDate = new DateTime(2020, 1, 3) };
            ProjectStudent ps27 = new ProjectStudent() { Student = s23, Course = c5, Project = p3, EnrollmentDate = new DateTime(2020, 5, 5) };
            ProjectStudent ps28 = new ProjectStudent() { Student = s24, Course = c4, Project = p3, EnrollmentDate = new DateTime(2020, 2, 2) };
            ProjectStudent ps29 = new ProjectStudent() { Student = s25, Course = c4, Project = p4, ProjectGrade = 100, EnrollmentDate = new DateTime(2020, 2, 4) };
            ProjectStudent ps30 = new ProjectStudent() { Student = s26, Course = c4, Project = p2, ProjectGrade = 96, EnrollmentDate = new DateTime(2020, 1, 15) };
            ProjectStudent ps31 = new ProjectStudent() { Student = s21, Course = c3, Project = p3, ProjectGrade = 78, EnrollmentDate = new DateTime(2020, 4, 4) };
            ProjectStudent ps32 = new ProjectStudent() { Student = s20, Course = c3, Project = p2, ProjectGrade = 83, EnrollmentDate = new DateTime(2020, 4, 14) };
            ProjectStudent ps33 = new ProjectStudent() { Student = s12, Course = c1, Project = p1, ProjectGrade = 82, EnrollmentDate = new DateTime(2020, 3, 13) };
            ProjectStudent ps34 = new ProjectStudent() { Student = s17, Course = c2, Project = p5, EnrollmentDate = new DateTime(2020, 3, 18) };
            ProjectStudent ps35 = new ProjectStudent() { Student = s16, Course = c2, Project = p4, EnrollmentDate = new DateTime(2020, 1, 21) };
            ProjectStudent ps36 = new ProjectStudent() { Student = s11, Course = c3, Project = p4, EnrollmentDate = new DateTime(2020, 1, 22) };
            ProjectStudent ps37 = new ProjectStudent() { Student = s17, Course = c1, Project = p3, ProjectGrade = 71, EnrollmentDate = new DateTime(2020, 2, 11) };
            ProjectStudent ps38 = new ProjectStudent() { Student = s14, Course = c1, Project = p2, ProjectGrade = 82, EnrollmentDate = new DateTime(2020, 2, 17) };
            ProjectStudent ps39 = new ProjectStudent() { Student = s9, Course = c2, Project = p2, ProjectGrade = 100, EnrollmentDate = new DateTime(2020, 1, 24) };
            ProjectStudent ps40 = new ProjectStudent() { Student = s18, Course = c4, Project = p1, ProjectGrade = 79, EnrollmentDate = new DateTime(2020, 3, 29) };
            ProjectStudent ps41 = new ProjectStudent() { Student = s26, Course = c3, Project = p4, ProjectGrade = 80, EnrollmentDate = new DateTime(2020, 4, 30) };
            ProjectStudent ps42 = new ProjectStudent() { Student = s28, Course = c2, Project = p4, ProjectGrade = 70, EnrollmentDate = new DateTime(2020, 5, 30) };
            ProjectStudent ps43 = new ProjectStudent() { Student = s5, Course = c5, Project = p1, EnrollmentDate = new DateTime(2020, 2, 15) };
            ProjectStudent ps44 = new ProjectStudent() { Student = s16, Course = c2, Project = p3, ProjectGrade = 99, EnrollmentDate = new DateTime(2020, 3, 13) };
            ProjectStudent ps45 = new ProjectStudent() { Student = s17, Course = c2, Project = p1, ProjectGrade = 89, EnrollmentDate = new DateTime(2020, 1, 18) };
            ProjectStudent ps46 = new ProjectStudent() { Student = s17, Course = c2, Project = p3, EnrollmentDate = new DateTime(2020, 2, 9) };
            ProjectStudent ps47 = new ProjectStudent() { Student = s18, Course = c4, Project = p4, ProjectGrade = 74, EnrollmentDate = new DateTime(2020, 4, 8) };
            ProjectStudent ps48 = new ProjectStudent() { Student = s19, Course = c6, Project = p4, ProjectGrade = 91, EnrollmentDate = new DateTime(2020, 3, 14) };
            ProjectStudent ps49 = new ProjectStudent() { Student = s19, Course = c3, Project = p2, EnrollmentDate = new DateTime(2020, 5, 12) };
            ProjectStudent ps50 = new ProjectStudent() { Student = s20, Course = c3, Project = p5, ProjectGrade = 82, EnrollmentDate = new DateTime(2020, 5, 11) };
            ProjectStudent ps51 = new ProjectStudent() { Student = s21, Course = c3, Project = p2, ProjectGrade = 98, EnrollmentDate = new DateTime(2020, 5, 18) };
            ProjectStudent ps52 = new ProjectStudent() { Student = s22, Course = c1, Project = p3, ProjectGrade = 96, EnrollmentDate = new DateTime(2020, 5, 19) };
            ProjectStudent ps53 = new ProjectStudent() { Student = s22, Course = c6, Project = p5, EnrollmentDate = new DateTime(2020, 3, 17) };
            ProjectStudent ps54 = new ProjectStudent() { Student = s23, Course = c5, Project = p2, EnrollmentDate = new DateTime(2020, 3, 19) };
            ProjectStudent ps55 = new ProjectStudent() { Student = s24, Course = c4, Project = p4, ProjectGrade = 80, EnrollmentDate = new DateTime(2020, 2, 20) };
            ProjectStudent ps56 = new ProjectStudent() { Student = s25, Course = c4, Project = p3, EnrollmentDate = new DateTime(2020, 1, 2) };
            ProjectStudent ps57 = new ProjectStudent() { Student = s26, Course = c3, Project = p1, ProjectGrade = 68, EnrollmentDate = new DateTime(2020, 3, 3) };
            ProjectStudent ps58 = new ProjectStudent() { Student = s27, Course = c3, Project = p4, ProjectGrade = 72, EnrollmentDate = new DateTime(2020, 4, 2) };
            ProjectStudent ps59 = new ProjectStudent() { Student = s28, Course = c2, Project = p5, ProjectGrade = 93, EnrollmentDate = new DateTime(2020, 5, 4) };
            ProjectStudent ps60 = new ProjectStudent() { Student = s29, Course = c5, Project = p2, EnrollmentDate = new DateTime(2020, 4, 17) };
            ProjectStudent ps61 = new ProjectStudent() { Student = s30, Course = c1, Project = p3, ProjectGrade = 92, EnrollmentDate = new DateTime(2020, 4, 14) };
            ProjectStudent ps62 = new ProjectStudent() { Student = s10, Course = c1, Project = p3, ProjectGrade = 67, EnrollmentDate = new DateTime(2020, 4, 13) };
            ProjectStudent ps63 = new ProjectStudent() { Student = s7, Course = c3, Project = p4, ProjectGrade = 66, EnrollmentDate = new DateTime(2020, 2, 5) };

            context.Courses.AddOrUpdate(x => x.Title, c1, c2, c3, c4, c5, c6);

            context.People.AddOrUpdate(x => new { x.FirstName, x.LastName }, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30, t1, t2, t3, t4, t5);

            context.StudentCourses.AddOrUpdate(x => x.EnrollmentDate, sc1, sc2, sc3, sc4, sc5, sc6, sc7, sc8, sc9, sc10, sc11, sc12, sc13, sc14, sc15, sc16, sc17, sc18, sc19, sc20, sc21, sc22,
            sc23, sc24, sc25, sc26, sc27, sc28, sc29, sc30, sc31, sc32, sc33, sc34, sc35, sc36, sc37, sc38, sc39, sc40, sc41, sc42);

            context.TrainerCourses.AddOrUpdate(x => x.EnrollmentDate, tc1, tc2, tc3, tc4, tc5, tc6, tc7, tc8, tc9, tc10, tc11, tc12, tc13, tc14, tc15, tc16, tc17, tc18);

            context.Projects.AddOrUpdate(x => x.Title, p1, p2, p3, p4, p5);

            context.ProjectStudents.AddOrUpdate(x => x.EnrollmentDate, ps1, ps2, ps3, ps4, ps5, ps6, ps7, ps8, ps9, ps10, ps11, ps12, ps13, ps14, ps15, ps16, ps17, ps18, ps19, ps20, ps21, ps22,

            ps23, ps24, ps25, ps26, ps27, ps28, ps29, ps30, ps31, ps32, ps33, ps34, ps35, ps36, ps37, ps38, ps39, ps40, ps41, ps42, ps43, ps44, ps45, ps46, ps47, ps48, ps49, ps50, ps51, ps52,

            ps53, ps54, ps55, ps56, ps57, ps58, ps59, ps60, ps61, ps62, ps63);

            context.SaveChanges();
        }
    }
}

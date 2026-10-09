using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KooliProjekt.Application.Data
{
    public static class SeedData
    {
        public static void Generate(ApplicationDbContext context)
        {
            if (context.Tootajad.Any() ||
                context.Autod.Any() ||
                context.Lepingud.Any() ||
                context.Autopargid.Any())
            {
                return;
            }

            SeedTootajad(context);
            SeedAutod(context);
            SeedLepingud(context);
            SeedAutopargid(context);
        }

        // Töötajate lisamine
        private static void SeedTootajad(ApplicationDbContext context)
        {
            var tootajad = new List<Tootaja>
            {
                new Tootaja { Nimi = "Mari Tamm", Kasutaja = "kasutaja01", Roll = "Administraator" },
                new Tootaja { Nimi = "Jaan Saar", Kasutaja = "kasutaja02", Roll = "Administraator" },
                new Tootaja { Nimi = "Kati Kask", Kasutaja = "kasutaja03", Roll = "Administraator" },
                new Tootaja { Nimi = "Martin Mägi", Kasutaja = "kasutaja04", Roll = "Töötaja" },
                new Tootaja { Nimi = "Laura Sepp", Kasutaja = "kasutaja05", Roll = "Töötaja" },
                new Tootaja { Nimi = "Andres Kukk", Kasutaja = "kasutaja06", Roll = "Töötaja" },
                new Tootaja { Nimi = "Anna Pärn", Kasutaja = "kasutaja07", Roll = "Töötaja" },
                new Tootaja { Nimi = "Kristjan Ilves", Kasutaja = "kasutaja08", Roll = "Töötaja" },
                new Tootaja { Nimi = "Liis Rebane", Kasutaja = "kasutaja09", Roll = "Töötaja" },
                new Tootaja { Nimi = "Markus Koppel", Kasutaja = "kasutaja10", Roll = "Töötaja" },
                new Tootaja { Nimi = "Kadri Oja", Kasutaja = "kasutaja11", Roll = "Töötaja" },
                new Tootaja { Nimi = "Rasmus Lepp", Kasutaja = "kasutaja12", Roll = "Töötaja" },
                new Tootaja { Nimi = "Eva Lill", Kasutaja = "kasutaja13", Roll = "Töötaja" },
                new Tootaja { Nimi = "Karl Põder", Kasutaja = "kasutaja14", Roll = "Töötaja" },
                new Tootaja { Nimi = "Helen Aas", Kasutaja = "kasutaja15", Roll = "Töötaja" },
                new Tootaja { Nimi = "Marten Vaher", Kasutaja = "kasutaja16", Roll = "Töötaja" },
                new Tootaja { Nimi = "Karin Roos", Kasutaja = "kasutaja17", Roll = "Töötaja" },
                new Tootaja { Nimi = "Peeter Kivi", Kasutaja = "kasutaja18", Roll = "Töötaja" },
                new Tootaja { Nimi = "Merilin Kuusk", Kasutaja = "kasutaja19", Roll = "Töötaja" },
                new Tootaja { Nimi = "Tarmo Teder", Kasutaja = "kasutaja20", Roll = "Töötaja" },
                new Tootaja { Nimi = "Sander Hallik", Kasutaja = "kasutaja21", Roll = "Töötaja" },
                new Tootaja { Nimi = "Eleri Aun", Kasutaja = "kasutaja22", Roll = "Töötaja" },
                new Tootaja { Nimi = "Siim Paju", Kasutaja = "kasutaja23", Roll = "Töötaja" },
                new Tootaja { Nimi = "Piret Kallas", Kasutaja = "kasutaja24", Roll = "Töötaja" },
                new Tootaja { Nimi = "Oliver Kaur", Kasutaja = "kasutaja25", Roll = "Töötaja" },
                new Tootaja { Nimi = "Sandra Mänd", Kasutaja = "kasutaja26", Roll = "Töötaja" },
                new Tootaja { Nimi = "Mihkel Org", Kasutaja = "kasutaja27", Roll = "Töötaja" },
                new Tootaja { Nimi = "Anneli Sild", Kasutaja = "kasutaja28", Roll = "Töötaja" },
                new Tootaja { Nimi = "Taavi Kask", Kasutaja = "kasutaja29", Roll = "Töötaja" },
                new Tootaja { Nimi = "Grete Vool", Kasutaja = "kasutaja30", Roll = "Töötaja" },
                new Tootaja { Nimi = "Erik Tamm", Kasutaja = "kasutaja31", Roll = "Töötaja" },
                new Tootaja { Nimi = "Birgit Saar", Kasutaja = "kasutaja32", Roll = "Töötaja" },
                new Tootaja { Nimi = "Henri Kukk", Kasutaja = "kasutaja33", Roll = "Töötaja" },
                new Tootaja { Nimi = "Keiu Lepp", Kasutaja = "kasutaja34", Roll = "Töötaja" },
                new Tootaja { Nimi = "Robert Mägi", Kasutaja = "kasutaja35", Roll = "Töötaja" }
            };

            context.Tootajad.AddRange(tootajad);
            context.SaveChanges();
        }

        // Autode lisamine
        private static void SeedAutod(ApplicationDbContext context)
        {
            var autod = new List<Auto>
            {
                new Auto { Mark = "Toyota", Mudel = "Corolla", Registreerimisnumber = "123ABC" },
                new Auto { Mark = "Volkswagen", Mudel = "Golf", Registreerimisnumber = "234BCD" },
                new Auto { Mark = "Skoda", Mudel = "Octavia", Registreerimisnumber = "345CDE" },
                new Auto { Mark = "Ford", Mudel = "Focus", Registreerimisnumber = "456DEF" },
                new Auto { Mark = "BMW", Mudel = "320d", Registreerimisnumber = "567EFG" },
                new Auto { Mark = "Audi", Mudel = "A4", Registreerimisnumber = "678FGH" },
                new Auto { Mark = "Volvo", Mudel = "V60", Registreerimisnumber = "789GHI" },
                new Auto { Mark = "Mercedes-Benz", Mudel = "C200", Registreerimisnumber = "890HIJ" },
                new Auto { Mark = "Kia", Mudel = "Ceed", Registreerimisnumber = "901IJK" },
                new Auto { Mark = "Hyundai", Mudel = "i30", Registreerimisnumber = "112JKL" },
                new Auto { Mark = "Mazda", Mudel = "6", Registreerimisnumber = "223KLM" },
                new Auto { Mark = "Honda", Mudel = "Civic", Registreerimisnumber = "334LMN" },
                new Auto { Mark = "Nissan", Mudel = "Qashqai", Registreerimisnumber = "445MNO" },
                new Auto { Mark = "Peugeot", Mudel = "308", Registreerimisnumber = "556NOP" },
                new Auto { Mark = "Renault", Mudel = "Clio", Registreerimisnumber = "667OPQ" },
                new Auto { Mark = "Opel", Mudel = "Astra", Registreerimisnumber = "778PQR" },
                new Auto { Mark = "Dacia", Mudel = "Duster", Registreerimisnumber = "889QRS" },
                new Auto { Mark = "Subaru", Mudel = "Outback", Registreerimisnumber = "990RST" },
                new Auto { Mark = "Tesla", Mudel = "Model 3", Registreerimisnumber = "101STU" },
                new Auto { Mark = "Toyota", Mudel = "RAV4", Registreerimisnumber = "212TUV" },
                new Auto { Mark = "Volkswagen", Mudel = "Passat", Registreerimisnumber = "323UVW" },
                new Auto { Mark = "Skoda", Mudel = "Superb", Registreerimisnumber = "434VWX" },
                new Auto { Mark = "Ford", Mudel = "Mondeo", Registreerimisnumber = "545WXY" },
                new Auto { Mark = "BMW", Mudel = "X3", Registreerimisnumber = "656XYZ" },
                new Auto { Mark = "Audi", Mudel = "Q5", Registreerimisnumber = "767ABC" },
                new Auto { Mark = "Volvo", Mudel = "XC60", Registreerimisnumber = "878BCD" },
                new Auto { Mark = "Mercedes-Benz", Mudel = "E220", Registreerimisnumber = "989CDE" },
                new Auto { Mark = "Kia", Mudel = "Sportage", Registreerimisnumber = "191DEF" },
                new Auto { Mark = "Hyundai", Mudel = "Tucson", Registreerimisnumber = "292EFG" },
                new Auto { Mark = "Mazda", Mudel = "CX-5", Registreerimisnumber = "393FGH" },
                new Auto { Mark = "Honda", Mudel = "CR-V", Registreerimisnumber = "494GHI" },
                new Auto { Mark = "Nissan", Mudel = "Juke", Registreerimisnumber = "595HIJ" },
                new Auto { Mark = "Peugeot", Mudel = "3008", Registreerimisnumber = "696IJK" },
                new Auto { Mark = "Renault", Mudel = "Megane", Registreerimisnumber = "797JKL" },
                new Auto { Mark = "Opel", Mudel = "Insignia", Registreerimisnumber = "898KLM" }
            };

            context.Autod.AddRange(autod);
            context.SaveChanges();
        }

        // Lepingute lisamine
        private static void SeedLepingud(ApplicationDbContext context)
        {
            var lepingud = new List<Leping>
            {
                new Leping { Too = "Korraline hooldus", Makse = 57m, Kirjeldus = "Autoteeninduse leping nr 1", Grandtotal = 57m },
                new Leping { Too = "Mootoriõli vahetus", Makse = 64m, Kirjeldus = "Autoteeninduse leping nr 2", Grandtotal = 64m },
                new Leping { Too = "Pidurite remont", Makse = 71m, Kirjeldus = "Autoteeninduse leping nr 3", Grandtotal = 71m },
                new Leping { Too = "Rehvide vahetus", Makse = 78m, Kirjeldus = "Autoteeninduse leping nr 4", Grandtotal = 78m },
                new Leping { Too = "Mootori diagnostika", Makse = 85m, Kirjeldus = "Autoteeninduse leping nr 5", Grandtotal = 85m },
                new Leping { Too = "Kliimaseadme hooldus", Makse = 92m, Kirjeldus = "Autoteeninduse leping nr 6", Grandtotal = 92m },
                new Leping { Too = "Veermiku remont", Makse = 99m, Kirjeldus = "Autoteeninduse leping nr 7", Grandtotal = 99m },
                new Leping { Too = "Korraline hooldus", Makse = 106m, Kirjeldus = "Autoteeninduse leping nr 8", Grandtotal = 106m },
                new Leping { Too = "Mootoriõli vahetus", Makse = 113m, Kirjeldus = "Autoteeninduse leping nr 9", Grandtotal = 113m },
                new Leping { Too = "Pidurite remont", Makse = 120m, Kirjeldus = "Autoteeninduse leping nr 10", Grandtotal = 120m },
                new Leping { Too = "Rehvide vahetus", Makse = 127m, Kirjeldus = "Autoteeninduse leping nr 11", Grandtotal = 127m },
                new Leping { Too = "Mootori diagnostika", Makse = 134m, Kirjeldus = "Autoteeninduse leping nr 12", Grandtotal = 134m },
                new Leping { Too = "Kliimaseadme hooldus", Makse = 141m, Kirjeldus = "Autoteeninduse leping nr 13", Grandtotal = 141m },
                new Leping { Too = "Veermiku remont", Makse = 148m, Kirjeldus = "Autoteeninduse leping nr 14", Grandtotal = 148m },
                new Leping { Too = "Korraline hooldus", Makse = 155m, Kirjeldus = "Autoteeninduse leping nr 15", Grandtotal = 155m },
                new Leping { Too = "Mootoriõli vahetus", Makse = 162m, Kirjeldus = "Autoteeninduse leping nr 16", Grandtotal = 162m },
                new Leping { Too = "Pidurite remont", Makse = 169m, Kirjeldus = "Autoteeninduse leping nr 17", Grandtotal = 169m },
                new Leping { Too = "Rehvide vahetus", Makse = 176m, Kirjeldus = "Autoteeninduse leping nr 18", Grandtotal = 176m },
                new Leping { Too = "Mootori diagnostika", Makse = 183m, Kirjeldus = "Autoteeninduse leping nr 19", Grandtotal = 183m },
                new Leping { Too = "Kliimaseadme hooldus", Makse = 190m, Kirjeldus = "Autoteeninduse leping nr 20", Grandtotal = 190m },
                new Leping { Too = "Veermiku remont", Makse = 197m, Kirjeldus = "Autoteeninduse leping nr 21", Grandtotal = 197m },
                new Leping { Too = "Korraline hooldus", Makse = 204m, Kirjeldus = "Autoteeninduse leping nr 22", Grandtotal = 204m },
                new Leping { Too = "Mootoriõli vahetus", Makse = 211m, Kirjeldus = "Autoteeninduse leping nr 23", Grandtotal = 211m },
                new Leping { Too = "Pidurite remont", Makse = 218m, Kirjeldus = "Autoteeninduse leping nr 24", Grandtotal = 218m },
                new Leping { Too = "Rehvide vahetus", Makse = 225m, Kirjeldus = "Autoteeninduse leping nr 25", Grandtotal = 225m },
                new Leping { Too = "Mootori diagnostika", Makse = 232m, Kirjeldus = "Autoteeninduse leping nr 26", Grandtotal = 232m },
                new Leping { Too = "Kliimaseadme hooldus", Makse = 239m, Kirjeldus = "Autoteeninduse leping nr 27", Grandtotal = 239m },
                new Leping { Too = "Veermiku remont", Makse = 246m, Kirjeldus = "Autoteeninduse leping nr 28", Grandtotal = 246m },
                new Leping { Too = "Korraline hooldus", Makse = 253m, Kirjeldus = "Autoteeninduse leping nr 29", Grandtotal = 253m },
                new Leping { Too = "Mootoriõli vahetus", Makse = 260m, Kirjeldus = "Autoteeninduse leping nr 30", Grandtotal = 260m },
                new Leping { Too = "Pidurite remont", Makse = 267m, Kirjeldus = "Autoteeninduse leping nr 31", Grandtotal = 267m },
                new Leping { Too = "Rehvide vahetus", Makse = 274m, Kirjeldus = "Autoteeninduse leping nr 32", Grandtotal = 274m },
                new Leping { Too = "Mootori diagnostika", Makse = 281m, Kirjeldus = "Autoteeninduse leping nr 33", Grandtotal = 281m },
                new Leping { Too = "Kliimaseadme hooldus", Makse = 288m, Kirjeldus = "Autoteeninduse leping nr 34", Grandtotal = 288m },
                new Leping { Too = "Veermiku remont", Makse = 295m, Kirjeldus = "Autoteeninduse leping nr 35", Grandtotal = 295m }
            };

            context.Lepingud.AddRange(lepingud);
            context.SaveChanges();
        }

        // Autopargi tööde lisamine
        private static void SeedAutopargid(ApplicationDbContext context)
        {
            var autopargid = new List<Autopark>
            {
                new Autopark { Staatus = "Töös", Kirjeldus = "Toyota Corolla õlivahetus", Toohind = 45m, Broneering = "BR-1001" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Volkswagen Golf pidurite remont", Toohind = 50m, Broneering = "BR-1002" },
                new Autopark { Staatus = "Broneeritud", Kirjeldus = "Skoda Octavia korraline hooldus", Toohind = 55m, Broneering = "BR-1003" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Ford Focus rehvide vahetus", Toohind = 60m, Broneering = "BR-1004" },
                new Autopark { Staatus = "Töös", Kirjeldus = "BMW 320d diagnostika", Toohind = 65m, Broneering = "BR-1005" },
                new Autopark { Staatus = "Broneeritud", Kirjeldus = "Audi A4 filtrite vahetus", Toohind = 70m, Broneering = "BR-1006" },
                new Autopark { Staatus = "Töös", Kirjeldus = "Volvo V60 veermiku kontroll", Toohind = 75m, Broneering = "BR-1007" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Toyota Corolla õlivahetus", Toohind = 80m, Broneering = "BR-1008" },
                new Autopark { Staatus = "Broneeritud", Kirjeldus = "Volkswagen Golf pidurite remont", Toohind = 85m, Broneering = "BR-1009" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Skoda Octavia korraline hooldus", Toohind = 90m, Broneering = "BR-1010" },
                new Autopark { Staatus = "Töös", Kirjeldus = "Ford Focus rehvide vahetus", Toohind = 95m, Broneering = "BR-1011" },
                new Autopark { Staatus = "Broneeritud", Kirjeldus = "BMW 320d diagnostika", Toohind = 100m, Broneering = "BR-1012" },
                new Autopark { Staatus = "Töös", Kirjeldus = "Audi A4 filtrite vahetus", Toohind = 105m, Broneering = "BR-1013" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Volvo V60 veermiku kontroll", Toohind = 110m, Broneering = "BR-1014" },
                new Autopark { Staatus = "Broneeritud", Kirjeldus = "Toyota Corolla õlivahetus", Toohind = 115m, Broneering = "BR-1015" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Volkswagen Golf pidurite remont", Toohind = 120m, Broneering = "BR-1016" },
                new Autopark { Staatus = "Töös", Kirjeldus = "Skoda Octavia korraline hooldus", Toohind = 125m, Broneering = "BR-1017" },
                new Autopark { Staatus = "Broneeritud", Kirjeldus = "Ford Focus rehvide vahetus", Toohind = 130m, Broneering = "BR-1018" },
                new Autopark { Staatus = "Töös", Kirjeldus = "BMW 320d diagnostika", Toohind = 135m, Broneering = "BR-1019" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Audi A4 filtrite vahetus", Toohind = 140m, Broneering = "BR-1020" },
                new Autopark { Staatus = "Broneeritud", Kirjeldus = "Volvo V60 veermiku kontroll", Toohind = 145m, Broneering = "BR-1021" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Toyota Corolla õlivahetus", Toohind = 150m, Broneering = "BR-1022" },
                new Autopark { Staatus = "Töös", Kirjeldus = "Volkswagen Golf pidurite remont", Toohind = 155m, Broneering = "BR-1023" },
                new Autopark { Staatus = "Broneeritud", Kirjeldus = "Skoda Octavia korraline hooldus", Toohind = 160m, Broneering = "BR-1024" },
                new Autopark { Staatus = "Töös", Kirjeldus = "Ford Focus rehvide vahetus", Toohind = 165m, Broneering = "BR-1025" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "BMW 320d diagnostika", Toohind = 170m, Broneering = "BR-1026" },
                new Autopark { Staatus = "Broneeritud", Kirjeldus = "Audi A4 filtrite vahetus", Toohind = 175m, Broneering = "BR-1027" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Volvo V60 veermiku kontroll", Toohind = 180m, Broneering = "BR-1028" },
                new Autopark { Staatus = "Töös", Kirjeldus = "Toyota Corolla õlivahetus", Toohind = 185m, Broneering = "BR-1029" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Volkswagen Golf pidurite remont", Toohind = 190m, Broneering = "BR-1030" },
                new Autopark { Staatus = "Broneeritud", Kirjeldus = "Skoda Octavia korraline hooldus", Toohind = 195m, Broneering = "BR-1031" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Ford Focus rehvide vahetus", Toohind = 200m, Broneering = "BR-1032" },
                new Autopark { Staatus = "Töös", Kirjeldus = "BMW 320d diagnostika", Toohind = 205m, Broneering = "BR-1033" },
                new Autopark { Staatus = "Valmis", Kirjeldus = "Audi A4 filtrite vahetus", Toohind = 210m, Broneering = "BR-1034" },
                new Autopark { Staatus = "Broneeritud", Kirjeldus = "Volvo V60 veermiku kontroll", Toohind = 215m, Broneering = "BR-1035" }
            };

            context.Autopargid.AddRange(autopargid);
            context.SaveChanges();
        }
    }
}
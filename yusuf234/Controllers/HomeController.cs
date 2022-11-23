using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using yusuf234.Models;

namespace yusuf234.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private List<Ogrenci> list;

        private List<Bolum> bolum;

        private List<Hobi> hobi;

        private List<Hoca> hoca;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            bolum = new List<Bolum>
            {
                new Bolum { BolumId=1, Adi="İnşaat Mühendisliği"},
                new Bolum { BolumId=2, Adi="Genetik Mühendisliği"},
                new Bolum { BolumId=3, Adi="Bilgisayar Programcılığı"},
            };

            hobi = new List<Hobi>
            {
                new Hobi { HobiId=1, Adi="bisiklet"},
                new Hobi { HobiId=2, Adi="araba"},
                new Hobi { HobiId=3, Adi="motosiklet"},
            };

            hoca = new List<Hoca>
            {
                new Hoca { HocaId=1, Adi="yusuf"},
                new Hoca { HocaId=2, Adi="meryem"},
                new Hoca { HocaId=3, Adi="elife"},
            };
                        

            list = new List<Ogrenci>()
            {
                new Ogrenci { OgrenciId=1, AdSoyad="Mehmet Tumec", BolumId=1, HobiId=2, HocaId=2, RHocaId=3},
                new Ogrenci { OgrenciId=2, AdSoyad="Ahmet Tumec", BolumId=2, HobiId=1, HocaId=2, RHocaId=3},
                new Ogrenci { OgrenciId=3, AdSoyad="Yusuf Akçakaya", BolumId=2, HobiId=2, HocaId=2, RHocaId = 3},
                new Ogrenci { OgrenciId=4, AdSoyad="Hakan Tumec", BolumId=2, HobiId=3, HocaId=3, RHocaId = 2},
                new Ogrenci { OgrenciId=5, AdSoyad="Caner Tumec", BolumId=3, HobiId=3, HocaId=1, RHocaId = 2},
                new Ogrenci { OgrenciId=6, AdSoyad="Mert Tumec", BolumId=3, HobiId=2, HocaId=3, RHocaId = 2}
            };
        }

        
        public IActionResult Form(int? id)
        {
            return PartialView(list.FirstOrDefault(i=>i.OgrenciId==id));
        }

        
        public IActionResult Kayit(Ogrenci ogrenci)
        {
            //Console.WriteLine(ogrenci.AdSoyad);
            //Console.WriteLine(ogrenci.BolumId);
            //Console.WriteLine(ogrenci.HobiId);
            //Console.WriteLine(ogrenci.HocaId);
            //Console.WriteLine(ogrenci.RHocaId);
            //---------
            list.Add(ogrenci);
            var ogrW = JsonConvert.SerializeObject(list);
            return Json(ogrW);
            //----------

        }

        public IActionResult Guncelle(Ogrenci ogrenci)
        {
            var liste = list.FirstOrDefault(x => x.OgrenciId == ogrenci.OgrenciId);
            liste.AdSoyad = ogrenci.AdSoyad;
            var jsonOgrenci = JsonConvert.SerializeObject(ogrenci);
            return Json(jsonOgrenci);
        }


        public IActionResult liste()
        {
            return PartialView(list);
        }
        public IActionResult Index()
        {
            return View();
        }
    }


}

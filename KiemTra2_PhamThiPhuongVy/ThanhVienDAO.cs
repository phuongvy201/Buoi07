using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BaiTapBuoi07
{
    internal class ThanhVienDAO
    {
        QLSVDbContext db = new QLSVDbContext();

        public List<ThanhVien> getList()
        {
            List<ThanhVien> list = db.ThanhViens.ToList();
            return list;
        }
        public int getCount()
        {
            return db.ThanhViens.Count();
        }
        public ThanhVien getRow(string username)
        {
            ThanhVien tv = db.ThanhViens.Where(m => m.UserName == username).First();
            return tv;
        }
        public void Insert(ThanhVien tv)
        {
            db.ThanhViens.Add(tv);
            db.SaveChanges();
        }
        public void Update(ThanhVien tv)
        {
            db.Entry(tv).State = EntityState.Modified;
            db.SaveChanges();
        }
    }

}
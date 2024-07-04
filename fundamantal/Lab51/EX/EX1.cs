using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX
{
    public abstract class NhanVien
    {
        public string Ten {  get; set; }
        public string DiaChia { get; set; }

        public abstract int TinhLuong();

        public abstract void HienThi();
    }

    public class CongNhan : NhanVien
    {
        public int SoLuongBanDuoc { get; set; }

        public int SoLuongSanPham { get; set; }
        public override void HienThi()
        {
            Console.WriteLine($"name: {Ten}");
            Console.WriteLine($"dia chi: {DiaChia}");
            Console.WriteLine($"soluong ban duoc: {SoLuongBanDuoc}");
            Console.WriteLine($"so luong san pham: {SoLuongSanPham}");
        }

        public override int TinhLuong()
        {
            return ((1000 * SoLuongSanPham + 100000 * SoLuongBanDuoc) *10)/100;
        }
    }


}


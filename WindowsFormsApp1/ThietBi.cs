namespace WindowsFormsApp1
{
    internal class ThietBi
    {
        private int soLuong;

        public ThietBi(int soLuong)
        {
            this.soLuong = soLuong;
        }

        public int SoLuong { get => soLuong; set => soLuong = value; }

        public int TinhTien(int soKW)
        {
            return DienNangTieuThu(soKW) * 1800;
        }

        public int DienNangTieuThu(int soKW)
        {
            return soKW * SoLuong;
        }
    }
}

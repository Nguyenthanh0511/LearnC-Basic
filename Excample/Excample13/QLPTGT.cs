using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample13
{
    internal class QLPTGT
    {
        private List<PhuongTien> phuongTiens;

        public QLPTGT()
        {
            this.phuongTiens = new List<PhuongTien>();
        }

        public QLPTGT(List<PhuongTien> phuongTiens)
        {
            this.phuongTiens = phuongTiens;
        }

        public void ThemPhuongTien(PhuongTien phuongTien)
        {
            this.phuongTiens.Add(phuongTien);
        }

        public List<PhuongTien> TimKiemMauSac(string mauSac)
        {
            List<PhuongTien> result = new List<PhuongTien>();

            result = this.phuongTiens.FindAll(phuongTien => phuongTien.mauSac == mauSac);

            return result;
        }
    }
}

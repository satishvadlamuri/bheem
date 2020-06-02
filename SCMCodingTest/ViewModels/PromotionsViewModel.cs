using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SCMCodingTest
{
    public class PromotionsViewModel :ViewModelBase
    {
        private readonly PromotionsModel promotionsModel = new PromotionsModel();
        public ICommand Aitemchanged { get; set; }
        public ICommand ApplyButton { get; set; }
        
        public int AItemCount
        {
            get
            {
                return promotionsModel.AItemCount;
            }
            set
            {
                promotionsModel.AItemCount = value;
                OnPropertyChanged("AItemCount");
            }
        }
        public int BItemCount
        {
            get
            {
                return promotionsModel.BItemCount;
            }
            set
            {
                promotionsModel.BItemCount = value;
                OnPropertyChanged("BItemCount");
            }
        }
        public int CItemCount
        {
            get
            {
                return promotionsModel.CItemCount;
            }
            set
            {
                promotionsModel.CItemCount = value;
                OnPropertyChanged("CItemCount");
            }
        }
        public int DItemCount
        {
            get
            {
                return promotionsModel.DItemCount;
            }
            set
            {
                promotionsModel.DItemCount = value;
                OnPropertyChanged("DItemCount");
            }
        }

        public int TotalPrice
        {
            get
            {
                return promotionsModel.TotalPrice;
            }
            set
            {
                promotionsModel.TotalPrice = value;
                OnPropertyChanged("TotalPrice");
            }
        }
        public int TotalPriceA
        {
            get
            {
                return promotionsModel.TotalPriceA;
            }
            set
            {
                promotionsModel.TotalPriceA = value;
                OnPropertyChanged("TotalPriceA");
            }
        }
        public int TotalPriceB
        {
            get
            {
                return promotionsModel.TotalPriceB;
            }
            set
            {
                promotionsModel.TotalPriceB = value;
                OnPropertyChanged("TotalPriceB");
            }
        }
        public int TotalPriceC
        {
            get
            {
                return promotionsModel.TotalPriceC;
            }
            set
            {
                promotionsModel.TotalPriceC = value;
                OnPropertyChanged("TotalPriceC");
            }
        }
        public int TotalPriceD
        {
            get
            {
                return promotionsModel.TotalPriceD;
            }
            set
            {
                promotionsModel.TotalPriceD = value;
                OnPropertyChanged("TotalPriceD");
            }
        }
        
        #region --- Constructor---
        public PromotionsViewModel()
        {
            InitializeWindow();
        }
        #endregion --- Constructor---
        private void InitializeWindow()
        {
            InitializeCommands();
        }
        /// <summary>
        /// Initializing commands
        /// </summary>
        private void InitializeCommands()
        {          
            this.ApplyButton = new RelayCommand<Button>(o => ApplyButtonOnClick());            
        }

        private void ApplyButtonOnClick()
        {
            try
            {
                TotalPrice = 0;
                //  A Item Price calculate
                int count = 0;

                count = AItemCount / 3;
                if (count > 0)
                {
                    TotalPriceA = 130 * count;
                }
                int reaminig = AItemCount % 3;
                if (reaminig > 0)
                    TotalPriceA += reaminig * Constants.PromotionA;

                //  B Item Price calculate
                count = BItemCount / 2;
                if (count > 0)
                    TotalPriceB = 45 * count;
                reaminig = BItemCount % 2;
                if (reaminig > 0)
                    TotalPriceB += reaminig * Constants.PromotionB;


                //  C Item Price calculate           

                if (CItemCount + DItemCount > 1)
                {
                    TotalPriceC = 0;
                    TotalPriceD = 30;
                }
                else if (CItemCount > 0)
                {
                    TotalPriceC = CItemCount * Constants.PromotionC;
                }
                else if (DItemCount > 0)
                {
                    TotalPriceD = DItemCount * Constants.PromotionD;
                }
                TotalPrice = TotalPriceA + TotalPriceB + TotalPriceC + TotalPriceD;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Check Values");
            }
                

        }
    }
}

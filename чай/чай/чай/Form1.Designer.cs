
namespace чай
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            {
case place_auction:
                {
                    screen.DisplayMessage("Please Enter a title for your Auction Item");
                    string ItemName = Convert.ToString(Console.ReadLine());
                    screen.DisplayMessage("Enter a start price for your item:");
                    double startPrice = Convert.ToDouble(Console.ReadLine());
                    screen.DisplayMessage("Now enter your reserve price for your item:");
                    double reservePrice = Convert.ToDouble(Console.ReadLine());
                    screen.DisplayMessage("Enter the closing date for your auction:");
                    DateTime closeDate = Convert.ToDateTime(Console.ReadLine());

                    // creating the auction
                    Auction aucttion = new Auction(ItemName, startPrice, reservePrice, closeDate);

                    // auction is entering auction list.
                    auctionList.Add(aucttion);

                    Console.WriteLine("auction is now created :)");
                    Console.WriteLine("Auction details are as follows:");
                    Console.WriteLine("Item name" + ItemName);
                    Console.WriteLine("The Starting Price" + startPrice);
                    Console.WriteLine("The Reserve Price" + reservePrice);
                    Console.WriteLine("Closing date of this auction" + closeDate);
                }
case browse_auction:
                {
                    if (auctionList.Count > 0)
                    {
                        Console.WriteLine("Existing Auctions:");
                        foreach (Auction aucttion in auctionList)
                        {
                            Console.WriteLine("Auction");
                        }

                    }
                    else
                    {
                        Console.WriteLine(" No existing auction appearing on the system");
                    }

                    break;
                }
case locate_auction:
                {
                    screen.DisplayMessageLine("Insert Auction ID: ");
                    break;
                }
case exit:
                {
                    screen.DisplayMessageLine("");
                    screen.DisplayMessageLine("System Shutting Down!");
                    userExit = true;
                    break;
                }
                default:
    {
                    screen.DisplayMessageLine("");
                    screen.DisplayMessageLine("Selection was not recognisable, please try again");
                    break;
                }
            }
            c#visual-studio-2010
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 557);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}


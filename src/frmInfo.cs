using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ais
{
    public partial class frmInfo : Form
    {
        private int th;

        public frmInfo(List<string> fields, string name) {
            int widthMax = 0;

            InitializeComponent();

            for (int i = 0; i < fields.Count; i++) {
                Label label = new Label {
                    Location = new Point(0, 20 * i + 11 * this.th),
                    Font = new Font("Lucida Console", 8f),
                    Padding = new Padding(10, 10, 0, 0)
                };

                if (fields[i].Contains("Timestamps"))
                    ParseTimestamps(label, fields[i]);
                else
                    label.Text = fields[i];

                this.Controls.Add(label);
            }

            foreach (object control in this.Controls) {
                if (control is Label) {
                    int labelTextLen = ((Label) control).Text.Split('\n')[0].Length;

                    if (labelTextLen > widthMax)
                        widthMax = labelTextLen;
                }
            }

            widthMax = widthMax * 8 + 10;

            foreach (object control in this.Controls) {
                if (control is Label) {
                    Label label = control as Label;

                    label.Size = new Size(widthMax, label.Height);
                }
            }

            this.Size = new Size(widthMax, 10 + 20 * (fields.Count + 1) + 11 * this.th + 20);
            this.Text = name + " info";
        }

        private void ParseTimestamps(Label label, string field) {
            string[] buf = field.Split(' ');
            string timestamps = "";

            for (int i = 1; i < buf.Length; i++) {
                if (i % 4 == 0 && i < buf.Length - 1) {
                    timestamps += buf[i] + "\n" + new string(' ', 12);

                    this.th++;
                }
                else
                    timestamps += buf[i] + " ";
            }

            label.Height += 11 * this.th;
            label.Text = "Timestamps: " + timestamps;
        }
    }
}


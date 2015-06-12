using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public partial class DTO : Component
    {
        public DTO()
        {
            InitializeComponent();
        }

        public DTO(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class T_group
    {
        public int id_group { get; set; }
        public int course_id { get; set; }
        public int quota { get; set; }
        public T_course t_course { get; set; }
    }
}

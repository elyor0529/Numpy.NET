// Copyright (c) 2019 by the SciSharp Team
// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy.Models;
using Python.Included;

namespace Numpy
{
    public static partial class np
    {
        
        /// <summary>
        /// Pads an array.
        /// 
        /// Notes
        /// 
        /// For an array with rank greater than 1, some of the padding of later
        /// axes is calculated from padding of previous axes.  This is easiest to
        /// think about with a rank 2 array where the corners of the padded array
        /// are calculated by using padded values from the first axis.
        /// 
        /// The padding function, if used, should return a rank 1 array equal in
        /// length to the vector argument with padded values replaced. It has the
        /// following signature:
        /// 
        /// where
        /// </summary>
        /// <param name="array">
        /// Input array
        /// </param>
        /// <param name="pad_width">
        /// Number of values padded to the edges of each axis.
        /// ((before_1, after_1), … (before_N, after_N)) unique pad widths
        /// for each axis.
        /// ((before, after),) yields same before and after pad for each axis.
        /// (pad,) or int is a shortcut for before = after = pad width for all
        /// axes.
        /// </param>
        /// <param name="mode">
        /// One of the following string values or a user supplied function.
        /// </param>
        /// <param name="stat_length">
        /// Used in ‘maximum’, ‘mean’, ‘median’, and ‘minimum’.  Number of
        /// values at edge of each axis used to calculate the statistic value.
        /// 
        /// ((before_1, after_1), … (before_N, after_N)) unique statistic
        /// lengths for each axis.
        /// 
        /// ((before, after),) yields same before and after statistic lengths
        /// for each axis.
        /// 
        /// (stat_length,) or int is a shortcut for before = after = statistic
        /// length for all axes.
        /// 
        /// Default is None, to use the entire axis.
        /// </param>
        /// <param name="constant_values">
        /// Used in ‘constant’.  The values to set the padded values for each
        /// axis.
        /// 
        /// ((before_1, after_1), … (before_N, after_N)) unique pad constants
        /// for each axis.
        /// 
        /// ((before, after),) yields same before and after constants for each
        /// axis.
        /// 
        /// (constant,) or int is a shortcut for before = after = constant for
        /// all axes.
        /// 
        /// Default is 0.
        /// </param>
        /// <param name="end_values">
        /// Used in ‘linear_ramp’.  The values used for the ending value of the
        /// linear_ramp and that will form the edge of the padded array.
        /// 
        /// ((before_1, after_1), … (before_N, after_N)) unique end values
        /// for each axis.
        /// 
        /// ((before, after),) yields same before and after end values for each
        /// axis.
        /// 
        /// (constant,) or int is a shortcut for before = after = end value for
        /// all axes.
        /// 
        /// Default is 0.
        /// </param>
        /// <param name="reflect_type">
        /// Used in ‘reflect’, and ‘symmetric’.  The ‘even’ style is the
        /// default with an unaltered reflection around the edge value.  For
        /// the ‘odd’ style, the extended part of the array is created by
        /// subtracting the reflected values from two times the edge value.
        /// </param>
        /// <returns>
        /// Padded array of rank equal to array with shape increased
        /// according to pad_width.
        /// </returns>
        public static NDarray pad(NDarray array, NDarray pad_width, string mode, int[] stat_length = null, int[] constant_values = null, int[] end_values = null, string reflect_type = null)
            => NumPy.Instance.pad(array, pad_width, mode, stat_length:stat_length, constant_values:constant_values, end_values:end_values, reflect_type:reflect_type);
        
        
    }
}

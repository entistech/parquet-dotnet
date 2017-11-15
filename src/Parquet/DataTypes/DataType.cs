﻿namespace Parquet.DataTypes
{
   /// <summary>
   /// Experimental:
   /// List of supported data types
   /// </summary>
   enum DataType
   {
      Unspecified,

      /// <summary>
      /// Boolean
      /// </summary>
      Boolean,

      /// <summary>
      /// Byte
      /// </summary>
      Byte,

      /// <summary>
      /// Signed byte data type
      /// </summary>
      SignedByte,

      /// <summary>
      /// Unsigned byte
      /// </summary>
      UnsignedByte,

      /// <summary>
      /// Short
      /// </summary>
      Short,

      /// <summary>
      /// Unsigned short
      /// </summary>
      UnsignedShort,

      Int16,

      UnsignedInt16,

      /// <summary>
      /// 32 bit integer
      /// </summary>
      Int32,

      /// <summary>
      /// 64 bit integer
      /// </summary>
      Int64,

      /// <summary>
      /// 96 bit integer
      /// </summary>
      Int96,

      /// <summary>
      /// Array of bytes
      /// </summary>
      ByteArray,

      /// <summary>
      /// UTF-8 string
      /// </summary>
      String,

      /// <summary>
      /// Float
      /// </summary>
      Float,

      /// <summary>
      /// Double
      /// </summary>
      Double,

      /// <summary>
      /// Decimal
      /// </summary>
      Decimal,

      /// <summary>
      /// DateTimeOffset
      /// </summary>
      DateTimeOffset,

      /// <summary>
      /// Interval
      /// </summary>
      Interval,

      /// <summary>
      /// List of elements
      /// </summary>
      List,

      /// <summary>
      /// Structure containing other elements
      /// </summary>
      Structure,

      /// <summary>
      /// Dictionary of key-value pairs
      /// </summary>
      Dictionary
   }
}

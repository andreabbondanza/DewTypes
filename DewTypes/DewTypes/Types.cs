using System;
using DewCore.Extensions.Strings;

namespace DewCore.Types
{
    namespace Base
    {
        /// <summary>
        /// Base class
        /// </summary>
        public abstract class DewBase
        {
            /// <summary>
            /// Exception object
            /// </summary>
            public Exception Exception { get; set; }
        }
        /// <summary>
        /// Dew Double
        /// </summary>
        public class DewString : DewBase
        {
            /// <summary>
            /// Boolean value
            /// </summary>
            public string Value { get; set; }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewString a, DewString b)
            {
                return b.Value == a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewString a, DewString b)
            {
                return b.Value != a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewString a, bool b)
            {
                return b == (a.Value.Length > 0);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewString a, bool b)
            {
                return b == (a.Value.Length <= 0);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewString(bool value)
            {
                var x = new DewString() { Value = value ? true.ToString() : false.ToString() };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewString(int value)
            {
                var x = new DewString() { Value = value.ToString() };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewString(byte value)
            {
                var x = new DewString() { Value = value.ToString() };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewString(short value)
            {
                var x = new DewString() { Value = value.ToString() };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewString(sbyte value)
            {
                var x = new DewString() { Value = value.ToString() };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewString(long value)
            {
                var x = new DewString() { Value = value.ToString() };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewString(float value)
            {
                var x = new DewString() { Value = value.ToString() };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewString(double value)
            {
                var x = new DewString() { Value = value.ToString() };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewString(string value)
            {
                var x = new DewString() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator bool(DewString value)
            {
                return value.Value.Length > 0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewString value)
            {
                return value.Value.ToLong();
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewString value)
            {
                return value.Value.ToInt();
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewString value)
            {
                return byte.Parse(value.Value);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewString value)
            {
                return short.Parse(value.Value);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewString value)
            {
                return sbyte.Parse(value.Value);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewString operator +(DewString value, DewString value1)
            {
                return value.Value + value1.Value;
            }
            /// <summary>
            /// Remove all character from second string to first string
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewString operator -(DewString value, DewString value1)
            {
                var result = value.Value;
                foreach (var item in value1.Value)
                {
                    result = value.Value.RemoveChar(item);
                }
                return result;
            }
            /// <summary>
            /// Equals
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                if (obj is DewString)
                {
                    var x = obj as DewString;
                    return x.Value == Value;
                }
                else
                    return false;
            }
            /// <summary>
            /// Return the hash code
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
        /// <summary>
        /// Dew Double
        /// </summary>
        public class DewDouble : DewBase
        {
            /// <summary>
            /// Boolean value
            /// </summary>
            public double Value { get; set; }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewDouble a, DewDouble b)
            {
                return b.Value == a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewDouble a, DewDouble b)
            {
                return b.Value != a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewDouble a, bool b)
            {
                return b == (a.Value > 0);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewDouble a, bool b)
            {
                return b == (a.Value <= 0);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewDouble(bool value)
            {
                var x = new DewDouble() { Value = value ? 1 : 0 };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewDouble(int value)
            {
                var x = new DewDouble() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewDouble(byte value)
            {
                var x = new DewDouble() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewDouble(short value)
            {
                var x = new DewDouble() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewDouble(sbyte value)
            {
                var x = new DewDouble() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewDouble(long value)
            {
                var x = new DewDouble() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewDouble(float value)
            {
                var x = new DewDouble() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewDouble(double value)
            {
                var x = new DewDouble() { Value = (float)value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewDouble(string value)
            {
                var x = new DewDouble() { Value = double.Parse(value) };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator bool(DewDouble value)
            {
                return value.Value > 0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewDouble value)
            {
                return (long)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewDouble value)
            {
                return (int)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewDouble value)
            {
                return (byte)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewDouble value)
            {
                return (short)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewDouble value)
            {
                return (sbyte)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator string(DewDouble value)
            {
                return value.Value.ToString();
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewDouble operator +(DewDouble value, DewDouble value1)
            {
                return value.Value + value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewDouble operator *(DewDouble value, DewDouble value1)
            {
                return value.Value * value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewDouble operator %(DewDouble value, DewDouble value1)
            {
                return value.Value % value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewDouble operator /(DewDouble value, DewDouble value1)
            {
                return value.Value / value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewDouble operator -(DewDouble value, DewDouble value1)
            {
                return value.Value - value1.Value;
            }
            /// <summary>
            /// Equals
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                if (obj is DewDouble)
                {
                    var x = obj as DewDouble;
                    return x.Value == Value;
                }
                else
                    return false;
            }
            /// <summary>
            /// Return the hash code
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
        /// <summary>
        /// Dew Float
        /// </summary>
        public class DewFloat : DewBase
        {
            /// <summary>
            /// Boolean value
            /// </summary>
            public float Value { get; set; }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewFloat a, DewFloat b)
            {
                return b.Value == a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewFloat a, DewFloat b)
            {
                return b.Value != a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewFloat a, bool b)
            {
                return b == (a.Value > 0);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewFloat a, bool b)
            {
                return b == (a.Value <= 0);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewFloat(bool value)
            {
                var x = new DewFloat() { Value = value ? 1 : 0 };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewFloat(int value)
            {
                var x = new DewFloat() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewFloat(byte value)
            {
                var x = new DewFloat() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewFloat(short value)
            {
                var x = new DewFloat() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewFloat(sbyte value)
            {
                var x = new DewFloat() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewFloat(long value)
            {
                var x = new DewFloat() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewFloat(float value)
            {
                var x = new DewFloat() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewFloat(double value)
            {
                var x = new DewFloat() { Value = (float)value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewFloat(string value)
            {
                var x = new DewFloat() { Value = float.Parse(value) };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator bool(DewFloat value)
            {
                return value.Value > 0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewFloat value)
            {
                return (long)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator float(DewFloat value)
            {
                return value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator double(DewFloat value)
            {
                return value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewFloat value)
            {
                return (int)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewFloat value)
            {
                return (byte)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewFloat value)
            {
                return (short)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewFloat value)
            {
                return (sbyte)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator string(DewFloat value)
            {
                return value.Value.ToString();
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewFloat operator +(DewFloat value, DewFloat value1)
            {
                return value.Value + value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewFloat operator *(DewFloat value, DewFloat value1)
            {
                return value.Value * value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewFloat operator %(DewFloat value, DewFloat value1)
            {
                return value.Value % value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewFloat operator /(DewFloat value, DewFloat value1)
            {
                return value.Value / value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewFloat operator -(DewFloat value, DewFloat value1)
            {
                return value.Value - value1.Value;
            }
            /// <summary>
            /// Equals
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                if (obj is DewFloat)
                {
                    var x = obj as DewFloat;
                    return x.Value == Value;
                }
                else
                    return false;
            }
            /// <summary>
            /// Return the hash code
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
        /// <summary>
        /// Dew Int 
        /// </summary>
        public class DewInt : DewBase
        {
            /// <summary>
            /// Boolean value
            /// </summary>
            public int Value { get; set; }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewInt a, DewInt b)
            {
                return b.Value == a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewInt a, DewInt b)
            {
                return b.Value != a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewInt a, bool b)
            {
                return b == (a.Value > 0);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewInt a, bool b)
            {
                return b == (a.Value <= 0);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewInt(bool value)
            {
                var x = new DewInt() { Value = value ? 1 : 0 };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewInt(int value)
            {
                var x = new DewInt() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewInt(byte value)
            {
                var x = new DewInt() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewInt(short value)
            {
                var x = new DewInt() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewInt(sbyte value)
            {
                var x = new DewInt() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewInt(long value)
            {
                var x = new DewInt() { Value = (int)value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewInt(string value)
            {
                var x = new DewInt() { Value = int.Parse(value) };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewInt(double value)
            {
                var x = new DewInt() { Value = (int)value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewInt(float value)
            {
                var x = new DewInt() { Value = (int)value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator bool(DewInt value)
            {
                return value.Value > 0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewInt value)
            {
                return value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewInt value)
            {
                return value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewInt value)
            {
                return (byte)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewInt value)
            {
                return (short)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewInt value)
            {
                return (sbyte)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator double(DewInt value)
            {
                return value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator float(DewInt value)
            {
                return value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator string(DewInt value)
            {
                return value.Value.ToString();
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewInt operator +(DewInt value, DewInt value1)
            {
                return value.Value + value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewInt operator *(DewInt value, DewInt value1)
            {
                return value.Value * value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewInt operator %(DewInt value, DewInt value1)
            {
                return value.Value % value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewInt operator /(DewInt value, DewInt value1)
            {
                return value.Value / value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewInt operator -(DewInt value, DewInt value1)
            {
                return value.Value - value1.Value;
            }
            /// <summary>
            /// Equals
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                if (obj is DewInt)
                {
                    var x = obj as DewInt;
                    return x.Value == Value;
                }
                else
                    return false;
            }
            /// <summary>
            /// Return the hash code
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
        /// <summary>
        /// Dew Long 
        /// </summary>
        public class DewLong : DewBase
        {
            /// <summary>
            /// Boolean value
            /// </summary>
            public long Value { get; set; }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewLong a, DewLong b)
            {
                return b.Value == a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewLong a, DewLong b)
            {
                return b.Value != a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewLong a, bool b)
            {
                return b == (a.Value > 0);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewLong a, bool b)
            {
                return b == (a.Value <= 0);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewLong(bool value)
            {
                var x = new DewLong() { Value = value ? 1 : 0 };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewLong(int value)
            {
                var x = new DewLong() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewLong(byte value)
            {
                var x = new DewLong() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewLong(short value)
            {
                var x = new DewLong() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewLong(sbyte value)
            {
                var x = new DewLong() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewLong(long value)
            {
                var x = new DewLong() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewLong(string value)
            {
                var x = new DewLong() { Value = long.Parse(value) };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewLong(double value)
            {
                var x = new DewLong() { Value = (long)value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewLong(float value)
            {
                var x = new DewLong() { Value = (long)value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator bool(DewLong value)
            {
                return value.Value > 0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewLong value)
            {
                return value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewLong value)
            {
                return (int)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewLong value)
            {
                return (byte)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewLong value)
            {
                return (short)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator double(DewLong value)
            {
                return value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator float(DewLong value)
            {
                return value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator string(DewLong value)
            {
                return value.Value.ToString();
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewLong value)
            {
                return (sbyte)value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewLong operator +(DewLong value, DewLong value1)
            {
                return value.Value + value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewLong operator *(DewLong value, DewLong value1)
            {
                return value.Value * value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewLong operator %(DewLong value, DewLong value1)
            {
                return value.Value % value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewLong operator /(DewLong value, DewLong value1)
            {
                return value.Value / value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewLong operator -(DewLong value, DewLong value1)
            {
                return value.Value - value1.Value;
            }
            /// <summary>
            /// Equals
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                if (obj is DewLong)
                {
                    var x = obj as DewLong;
                    return x.Value == Value;
                }
                else
                    return false;
            }
            /// <summary>
            /// Return the hash code
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
        /// <summary>
        /// Dew Bool 
        /// </summary>
        public class DewBool : DewBase
        {
            /// <summary>
            /// Boolean value
            /// </summary>
            public bool Value { get; set; }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewBool a, DewBool b)
            {
                return b.Value == a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewBool a, DewBool b)
            {
                return b.Value != a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewBool a, bool b)
            {
                return b == a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewBool a, bool b)
            {
                return b != a.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewBool(bool value)
            {
                var x = new DewBool() { Value = value };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewBool(int value)
            {
                var x = new DewBool() { Value = value > 0 };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewBool(byte value)
            {
                var x = new DewBool() { Value = value > 0 };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewBool(short value)
            {
                var x = new DewBool() { Value = value > 0 };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewBool(sbyte value)
            {
                var x = new DewBool() { Value = value > 0 };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator DewBool(long value)
            {
                var x = new DewBool() { Value = value > 0 };
                return x;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator bool(DewBool value)
            {
                return value.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewBool value)
            {
                return value.Value ? 1 : 0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewBool value)
            {
                return value.Value ? 1 : 0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewBool value)
            {
                return value.Value ? (byte)1 : (byte)0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewBool value)
            {
                return value.Value ? (short)1 : (short)0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewBool value)
            {
                return value.Value ? (sbyte)1 : (sbyte)0;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewBool operator +(DewBool value, DewBool value1)
            {
                return value.Value || value1.Value;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewBool operator *(DewBool value, DewBool value1)
            {
                return value.Value && value1.Value;
            }
            /// <summary>
            /// Equals
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                if (obj is DewBool)
                {
                    var x = obj as DewBool;
                    return x.Value == Value;
                }
                else
                    return false;
            }
            /// <summary>
            /// Return the hash code
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
    }
    namespace AspNetCore
    {
        /// <summary>
        /// Bag for view data and dictionary
        /// </summary>
        /// <typeparam name="Translator"></typeparam>
        /// <typeparam name="Bag"></typeparam>
        public class ViewData<Translator, Bag>
        {
            /// <summary>
            /// Dictionary object
            /// </summary>
            public Translator Language { get; set; }
            /// <summary>
            /// View Bag
            /// </summary>
            public Bag Data { get; set; }
        }
        /// <summary>
        /// Standard response error
        /// </summary>
        public class StandardResponseError
        {
            /// <summary>
            /// Error description
            /// </summary>
            public string Desc { get; set; }
            /// <summary>
            /// Error number
            /// </summary>
            public int Number { get; set; }
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="desc"></param>
            public StandardResponseError(string desc)
            {
                Desc = desc;
            }
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="desc"></param>
            /// <param name="num"></param>
            public StandardResponseError(string desc, int num)
            {
                Desc = desc;
                Number = num;
            }
            /// <summary>
            /// Constructor
            /// </summary>
            public StandardResponseError() { }
        }
        /// <summary>
        /// Standard response object (good for anonymus objects)
        /// </summary>
        public class StandardResponse
        {
            /// <summary>
            /// Data
            /// </summary>
            public object Data { get; set; } = null;
            /// <summary>
            /// Error response 
            /// </summary>
            public StandardResponseError Error { get; set; } = new StandardResponseError();
            /// <summary>
            /// Return a new response object
            /// </summary>
            /// <returns></returns>
            public static StandardResponse GetResponse()
            {
                return new StandardResponse();
            }
            /// <summary>
            /// Return the object as json string
            /// </summary>
            /// <returns></returns>
            public string GetJson()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }

        }
        /// <summary>
        /// Standard response object
        /// </summary>
        public class StandardResponse<T> where T : class
        {
            /// <summary>
            /// Data
            /// </summary>
            public T Data { get; set; } = null;
            /// <summary>
            /// Error response 
            /// </summary>
            public StandardResponseError Error { get; set; } = new StandardResponseError();
            /// <summary>
            /// Return a new response object
            /// </summary>
            /// <returns></returns>
            public static StandardResponse<T> GetResponse()
            {
                return new StandardResponse<T>();
            }
            /// <summary>
            /// Return the object as json string
            /// </summary>
            /// <returns></returns>
            public string GetJson()
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this);
            }
        }
    }
}

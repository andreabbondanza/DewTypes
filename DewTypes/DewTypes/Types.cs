using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DewCore.Extensions.Strings;
using System.Reflection;
using DewCore.Abstract.Types;
using System.Reflection.Emit;
using System.Runtime.Serialization;

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
        /// Dew String
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
            public static DewBool operator ==(DewString a, DewString b) => b.Value == a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewString a, DewString b) => b.Value != a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewString a, bool b) => b == (a.Value.Length > 0);
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewString a, bool b) => b == (a.Value.Length <= 0);
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
            public static implicit operator bool(DewString value) => value.Value.Length > 0;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewString value) => value.Value.ToLong();
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewString value) => value.Value.ToInt();
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewString value) => byte.Parse(value.Value);
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewString value) => short.Parse(value.Value);
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewString value) => sbyte.Parse(value.Value);
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewString operator +(DewString value, DewString value1) => value.Value + value1.Value;
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
            public static DewBool operator ==(DewDouble a, DewDouble b) => b.Value == a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewDouble a, DewDouble b) => b.Value != a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewDouble a, bool b) => b == (a.Value > 0);
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewDouble a, bool b) => b == (a.Value <= 0);

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
            public static implicit operator bool(DewDouble value) => value.Value > 0;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewDouble value) => (long)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewDouble value) => (int)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewDouble value) => (byte)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewDouble value) => (short)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewDouble value) => (sbyte)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator string(DewDouble value) => value.Value.ToString();
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewDouble operator +(DewDouble value, DewDouble value1) => value.Value + value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewDouble operator *(DewDouble value, DewDouble value1) => value.Value * value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewDouble operator %(DewDouble value, DewDouble value1) => value.Value % value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewDouble operator /(DewDouble value, DewDouble value1) => value.Value / value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewDouble operator -(DewDouble value, DewDouble value1) => value.Value - value1.Value;
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
            public static DewBool operator ==(DewFloat a, DewFloat b) => b.Value == a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewFloat a, DewFloat b) => b.Value != a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewFloat a, bool b) => b == (a.Value > 0);
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewFloat a, bool b) => b == (a.Value <= 0);
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
            public static implicit operator bool(DewFloat value) => value.Value > 0;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewFloat value) => (long)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator float(DewFloat value) => value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator double(DewFloat value) => value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewFloat value) => (int)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewFloat value) => (byte)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewFloat value) => (short)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewFloat value) => (sbyte)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator string(DewFloat value) => value.Value.ToString();
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewFloat operator +(DewFloat value, DewFloat value1) => value.Value + value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewFloat operator *(DewFloat value, DewFloat value1) => value.Value * value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewFloat operator %(DewFloat value, DewFloat value1) => value.Value % value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewFloat operator /(DewFloat value, DewFloat value1) => value.Value / value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewFloat operator -(DewFloat value, DewFloat value1) => value.Value - value1.Value;
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
            public static DewBool operator ==(DewInt a, DewInt b) => b.Value == a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewInt a, DewInt b) => b.Value != a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewInt a, bool b) => b == (a.Value > 0);
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewInt a, bool b) => b == (a.Value <= 0);
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
            public static implicit operator bool(DewInt value) => value.Value > 0;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewInt value) => value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewInt value) => value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewInt value) => (byte)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewInt value) => (short)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewInt value) => (sbyte)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator double(DewInt value) => value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator float(DewInt value) => value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator string(DewInt value) => value.Value.ToString();
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewInt operator +(DewInt value, DewInt value1) => value.Value + value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewInt operator *(DewInt value, DewInt value1) => value.Value * value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewInt operator %(DewInt value, DewInt value1) => value.Value % value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewInt operator /(DewInt value, DewInt value1) => value.Value / value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewInt operator -(DewInt value, DewInt value1) => value.Value - value1.Value;
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
            public static DewBool operator ==(DewLong a, DewLong b) => b.Value == a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewLong a, DewLong b) => b.Value != a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewLong a, bool b) => b == (a.Value > 0);
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewLong a, bool b) => b == (a.Value <= 0);
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
            public static implicit operator bool(DewLong value) => value.Value > 0;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewLong value) => value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewLong value) => (int)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewLong value) => (byte)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewLong value) => (short)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator double(DewLong value) => value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator float(DewLong value) => value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator string(DewLong value) => value.Value.ToString();
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewLong value) => (sbyte)value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewLong operator +(DewLong value, DewLong value1) => value.Value + value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewLong operator *(DewLong value, DewLong value1) => value.Value * value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewLong operator %(DewLong value, DewLong value1) => value.Value % value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewLong operator /(DewLong value, DewLong value1) => value.Value / value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewLong operator -(DewLong value, DewLong value1) => value.Value - value1.Value;
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
            public static DewBool operator ==(DewBool a, DewBool b) => b.Value == a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewBool a, DewBool b) => b.Value != a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator ==(DewBool a, bool b) => b == a.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="a"></param>
            /// <param name="b"></param>
            /// <returns></returns>
            public static DewBool operator !=(DewBool a, bool b) => b != a.Value;
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
            public static implicit operator bool(DewBool value) => value.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator long(DewBool value) => value.Value ? 1 : 0;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator int(DewBool value) => value.Value ? 1 : 0;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator byte(DewBool value) => value.Value ? (byte)1 : (byte)0;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator short(DewBool value) => value.Value ? (short)1 : (short)0;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator sbyte(DewBool value) => value.Value ? (sbyte)1 : (sbyte)0;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewBool operator +(DewBool value, DewBool value1) => value.Value || value1.Value;
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            /// <param name="value1"></param>
            /// <returns></returns>
            public static DewBool operator *(DewBool value, DewBool value1) => value.Value && value1.Value;
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
    namespace Complex
    {

        /// <summary>
        /// Translator helper for middleware
        /// </summary>
        public class DewLocalizer : IDewLocalizer
        {
            private Dictionary<string, string> _dictionary;
            /// <summary>
            /// Search a string into dictionary, if not found return the key (useful if you use the value as key in your default language)
            /// </summary>
            /// <param name="key">Key value</param>
            /// <returns></returns>
            public string GetString(string key)
            {
                var s = _dictionary.FirstOrDefault(x => x.Key == key);
                if (s.Equals(default(KeyValuePair<string, string>)))
                {
                    return key;
                }
                return s.Value;
            }
            /// <summary>
            /// Search a string into dictionary, if not found return the default
            /// </summary>
            /// <param name="key">Key value</param>
            /// <param name="def">Default value</param>
            /// <returns></returns>
            public string GetString(string key, string def)
            {
                var s = _dictionary.FirstOrDefault(x => x.Key == key);
                if (s.Equals(default(KeyValuePair<string, string>)))
                {
                    return def;
                }
                return s.Value;
            }
            /// <summary>
            /// Return the key value
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            /// <exception cref="ArgumentNullException"></exception>
            /// <exception cref="InvalidOperationException"></exception>
            /// <exception cref="NullReferenceException"></exception>
            public string this[string key]
            {
                get { return _dictionary.First(x => x.Key == key).Value; }
            }
            /// <summary>
            /// Return the internal string dictionary
            /// </summary>
            /// <returns></returns>
            public Dictionary<string, string> GetInternalDictionary()
            {
                return _dictionary;
            }
            /// <summary>
            /// Read the dictionary from the file
            /// </summary>
            /// <param name="file"></param>
            /// <returns></returns>
            public async Task LoadDictionaryFromFiles(string file)
            {
                string localizationJson = null;
                using (Stream stream = File.OpenRead(file))
                {
                    using (StreamReader streamReader = new StreamReader(stream))
                    {
                        localizationJson = await streamReader.ReadToEndAsync();
                    }
                }
                _dictionary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(localizationJson);
            }
            /// <summary>
            /// Load a new dictionary (ovveride the old)
            /// </summary>
            /// <param name="dictionary"></param>
            public void LoadDictionary(Dictionary<string, string> dictionary)
            {
                _dictionary = dictionary;
            }
            /// <summary>
            /// Reset dictionary
            /// </summary>
            public void ResetDictionary()
            {
                _dictionary.Clear();
            }

            /// <summary>
            /// Constructor
            /// </summary>
            public DewLocalizer()
            {

            }
        }
    }
}
namespace DewCore.Abstract.Types
{
    /// <summary>
    /// Service interface
    /// </summary>
    public interface IDewLocalizer
    {
        /// <summary>
        /// Return the key if string is not present
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string GetString(string key);
        /// <summary>
        /// return def if string is not present
        /// </summary>
        /// <param name="key"></param>
        /// <param name="def"></param>
        /// <returns></returns>
        string GetString(string key, string def);
        /// <summary>
        /// return the raw dictionary
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetInternalDictionary();
        /// <summary>
        /// read dictionary
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        Task LoadDictionaryFromFiles(string file);
        /// <summary>
        /// Load a new dictionary (ovveride the old)
        /// </summary>
        /// <param name="dictionary"></param>
        void LoadDictionary(Dictionary<string, string> dictionary);
        /// <summary>
        /// Reset dictionary collection
        /// </summary>
        void ResetDictionary();
    }
    /// <summary>
    /// A getter for anonymus types
    /// </summary>
    public interface IAnonymousGetter
    {
        /// <summary>
        /// Return the first property of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T GetT<T>();
        /// <summary>
        /// Return the property with param name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="PropertyName"></param>
        /// <returns></returns>
        T GetT<T>(string PropertyName);
    }
    /// <summary>
    /// Anonymous type
    /// </summary>
    public class Anonymous : IAnonymousGetter
    {
        /// <summary>
        /// Wrap object
        /// </summary>
        /// <param name="toWrap"></param>
        /// <returns></returns>
        public static Anonymous Wrap(object toWrap)
        {
            return new Anonymous(toWrap);
        }
        /// <summary>
        /// Data source
        /// </summary>
        public object Source { get; set; }
        /// <summary>
        /// Return the first property of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetT<T>()
        {
            var properties = Source.GetType().GetRuntimeProperties();
            T result = default(T);
            PropertyInfo prop = null;
            foreach (var item in properties)
            {
                var a = item.PropertyType;
                var b = typeof(T);
                if (a == b)
                    prop = item;
            }
            if (prop != null)
                result = (T)prop.GetValue(Source);
            else
                throw new NotImplementedException();
            return result;

        }
        /// <summary>
        /// Return the property with param name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="PropertyName"></param>
        /// <returns></returns>
        public T GetT<T>(string PropertyName)
        {
            var properties = Source.GetType().GetRuntimeProperties();
            T result = default(T);
            var prop = properties.FirstOrDefault(x => x.Name == PropertyName);
            if (prop != null)
                result = (T)prop.GetValue(Source);
            else
                throw new NotImplementedException();
            return result;
        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="toWrap"></param>
        public Anonymous(object toWrap)
        {
            Source = toWrap;
        }
    }
    /// <summary>
    /// Extend object with anonymous wrapper
    /// </summary>
}
namespace DewCore.Extensions.Abstract
{
    /// <summary>
    /// Deep clone for object
    /// </summary>
    public static class CloneExtension
    {
        /// <summary>
        /// Execute a deep clone, class references must be acyclic
        /// </summary>
        /// <param name="o"></param>        
        /// <returns></returns>
        public static object DeepClone(this object o)
        {
            var type = o.GetType();
            if (type.IsPrimitive || type.IsEnum || type == typeof(string))
            {
                return o;
            }
            if (type.IsArray)
            {
                Type typeElement = Type.GetType(type.FullName.Replace("[]", string.Empty));
                var array = o as Array;
                var copiedArray = Array.CreateInstance(typeElement, array.Length);
                for (int i = 0; i < array.Length; i++)
                {
                    copiedArray.SetValue(array.GetValue(i).DeepClone(), i);
                }
                return copiedArray;
            }
            if (type.IsClass || type.IsValueType)
            {
                object copiedObject = null;
                if (o is ICloneable)
                    copiedObject = (o as ICloneable).Clone();
                else
                    copiedObject = Activator.CreateInstance(type);
                var events = type.GetEvents(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (var field in fields)
                {
                    object fieldValue = field.GetValue(o);
                    //prevent recursive stack overflow from events
                    if (fieldValue != null && !events.Any(x => x.Name == field.Name))
                    {
                        field.SetValue(copiedObject, fieldValue.DeepClone());
                    }
                }
                foreach (var prop in properties)
                {
                    object propValue = prop.GetValue(o);
                    if (propValue != null)
                    {
                        if (prop.CanWrite)
                            prop.SetValue(copiedObject, propValue.DeepClone());
                    }
                }
                return copiedObject;
            }
            return null;
        }
        /// <summary>
        /// Execute a deep copy, class references must be acyclic
        /// </summary>
        /// <param name="o"></param>        
        /// <returns></returns>
        public static object DeepCopy(object o)
        {
            var type = o.GetType();
            if (type.IsPrimitive || type.IsEnum || type == typeof(string))
            {
                return o;
            }
            if (type.IsArray)
            {
                Type typeElement = Type.GetType(type.FullName.Replace("[]", string.Empty));
                var array = o as Array;
                var copiedArray = Array.CreateInstance(typeElement, array.Length);
                for (int i = 0; i < array.Length; i++)
                {
                    copiedArray.SetValue(DeepCopy(array.GetValue(i)), i);
                }
                return copiedArray;
            }
            if (type.IsClass || type.IsValueType)
            {
                object copiedObject = null;
                if (o is ICloneable)
                    copiedObject = (o as ICloneable).Clone();
                else
                    copiedObject = Activator.CreateInstance(type);
                var events = type.GetEvents(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                foreach (var field in fields)
                {
                    object fieldValue = field.GetValue(o);
                    //prevent recursive stack overflow from events
                    if (fieldValue != null && !events.Any(x => x.Name == field.Name))
                    {
                        field.SetValue(copiedObject, DeepCopy(fieldValue));
                    }
                }
                foreach (var prop in properties)
                {
                    object propValue = prop.GetValue(o);
                    if (propValue != null)
                    {
                        if (prop.CanWrite)
                            prop.SetValue(copiedObject, DeepCopy(propValue));
                    }
                }
                return copiedObject;
            }
            return null;
        }
    }

    /// <summary>
    /// Extension for anonymous utility
    /// </summary>
    public static class AnonymousExtension
    {
        /// <summary>
        /// Return a property from an object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static T GetProperty<T>(this object obj, string property) => new Anonymous(obj).GetT<T>(property);
    }
    public static class DewMethod
    {
        public static Action Method(Action callback)
        {
            return callback;
        }
        public static Func<TResult> Function<TResult>(Func<TResult> callback)
        {
            return callback;
        }
        public static Func<T, TResult> Function<T, TResult>(T arg, Func<T, TResult> callback)
        {
            return callback;
        }
    }

    /// <summary>
    /// Extension for anonymous classes
    /// </summary>
    public static class DewObjectExtension
    {
        private static bool _firstTime = true;
        private static AssemblyBuilder _assembly = null;
        private static ModuleBuilder _module = null;
        /// <summary>
        /// Implement interface in runtime
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="o"></param>
        /// <returns></returns>
        public static T Implements<T>(this object o)
        {
            GenerateBase();
            if (!typeof(T).IsInterface)
                throw new ArgumentException();
            var _typeBuilder = _module.DefineType(new ObjectIDGenerator().GetId(o, out _firstTime).ToString(), TypeAttributes.Public);
            _typeBuilder.AddInterfaceImplementation(typeof(T));
            _typeBuilder = GenerateClass(_typeBuilder, o, typeof(T));
            TypeInfo result = _typeBuilder.CreateTypeInfo();
            T baseClass = (T)Activator.CreateInstance(result.AsType());
            return baseClass;
        }
        private static TypeBuilder GenerateClass(TypeBuilder builder, object current, Type targetInterface = null)
        {
            var reflection = current.GetType();
            var iproperties = targetInterface?.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
            var properties = reflection.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
            var events = reflection.GetRuntimeEvents();
            var methods = reflection.GetRuntimeMethods();
            var fields = reflection.GetRuntimeFields();
            foreach (var item in properties)
            {
                builder = CreateProperty(item, builder, item.GetCustomAttributes(true));
            }
            foreach (var item in iproperties)
            {
                builder = CreateProperty(item, builder, item.GetCustomAttributes(true), true);
            }
            //foreach (var item in fields)
            //{
            //    builder = CreateProperty(item.Name, item.PropertyType, builder, item.GetValue(current));
            //}
            //foreach (var item in methods)
            //{
            //    builder = CreateProperty(item.Name, item.PropertyType, builder, item.GetValue(current));
            //}
            //foreach (var item in events)
            //{
            //    builder = CreateProperty(item.Name, item.PropertyType, builder, item.GetValue(current));
            //}
            return builder;
        }

        private static TypeBuilder CreateEvent(string eName, Type eType, TypeBuilder typeBuilder, object[] attributes)
        {
            return null;
        }
        private static TypeBuilder CreateField(string fName, Type fType, TypeBuilder typeBuilder, object[] attributes)
        {
            return null;
        }
        private static TypeBuilder CreateMethod(string mName, Type mType, TypeBuilder typeBuilder, object[] attributes)
        {
            return null;
        }
        private static TypeBuilder CreateProperty(PropertyInfo prop, TypeBuilder typeBuilder, object[] attributes, bool extend = false)
        {
            FieldBuilder fieldBuilder = typeBuilder.DefineField("_" + prop.Name.Camelize(), prop.PropertyType, FieldAttributes.Private);
            PropertyBuilder propertyBuilder = typeBuilder.DefineProperty(prop.Name, PropertyAttributes.HasDefault, prop.PropertyType, null);

            if (prop.CanRead)
            {
                MethodBuilder getPropMthdBldr = typeBuilder.DefineMethod("get_" + prop.Name,
                                                                               MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig,
                                                                              prop.PropertyType, Type.EmptyTypes);
                ILGenerator getIl = getPropMthdBldr.GetILGenerator();
                MethodInfo getMethodInfo = prop.GetGetMethod();

                getIl.Emit(OpCodes.Ldarg_0);
                getIl.Emit(OpCodes.Ldfld, fieldBuilder);
                getIl.Emit(OpCodes.Ret);

                propertyBuilder.SetGetMethod(getPropMthdBldr);
                if (extend)
                    typeBuilder.DefineMethodOverride(getPropMthdBldr, getMethodInfo);

            }

            if (prop.CanWrite)
            {
                MethodBuilder setPropMthdBldr = typeBuilder.DefineMethod("set_" + prop.Name,
                                                                  MethodAttributes.Public | MethodAttributes.Virtual | MethodAttributes.HideBySig,
                                                                  null, new[] { prop.PropertyType });

                ILGenerator setIl = setPropMthdBldr.GetILGenerator();
                MethodInfo setMethodInfo = prop.GetSetMethod();

                setIl.Emit(OpCodes.Ldarg_0);      // Load "this"
                setIl.Emit(OpCodes.Ldarg_1);      // Load "value" onto the stack
                setIl.Emit(OpCodes.Stfld, fieldBuilder);
                setIl.Emit(OpCodes.Ret);          // Return nothing
                propertyBuilder.SetSetMethod(setPropMthdBldr);
                if (extend)
                    typeBuilder.DefineMethodOverride(setPropMthdBldr, setMethodInfo);
            }
            List<CustomAttributeBuilder> cBuilders = new List<CustomAttributeBuilder>();
            foreach (var item in attributes)
            {
                cBuilders.Add(new CustomAttributeBuilder(item.GetType().GetConstructor(Type.EmptyTypes), Type.EmptyTypes));
            }
            if (cBuilders.Count > 0)
            {
                foreach (var item in cBuilders)
                {
                    propertyBuilder.SetCustomAttribute(item);
                }
            }


            return typeBuilder;
        }

        private static void GenerateBase()
        {
            if (_assembly is null)
            {
                AssemblyName aname = new AssemblyName("_dewClassBuilder");
                _assembly = AssemblyBuilder.DefineDynamicAssembly(aname, AssemblyBuilderAccess.Run);
                _module = _assembly.DefineDynamicModule("_dewClassBuilder" + "_mod");
            }
        }
    }



}

using System;
using System.Collections.Generic;

namespace iLab11ProtoNg.Core.Domain
{
    public static class Ensure
    {
        public static void ArgumentNotNull(object argument, string name)
        {
            if (argument == null) throw new CustomValidationException(String.Format(EntityMessage.NullArgument, name));
        }

        public static void ArgumentIsNull(object argument, string name)
        {
            if (argument != null)
                throw new CustomValidationException(String.Format(EntityMessage.NotNullArgument, name));
        }

        public static void ArgumentNotNullOrEmpty(string argument, string name)
        {
            if (string.IsNullOrEmpty(argument))
                throw new CustomValidationException(String.Format(EntityMessage.NullOrEmptyArgument, name));
        }

        public static void ArgumentListNotNullOrEmpty<T>(ICollection<T> argument, string name)
        {
            if (argument == null || argument.Count == 0)
                throw new CustomValidationException(String.Format(EntityMessage.NullOrEmptyListArgument, name));
        }

        public static void ArgumentValidId(int argument, string name)
        {
            if (argument < 1) throw new CustomValidationException(String.Format(EntityMessage.InvalidIdArgument, name));
        }

        public static void ArgumentValidDate(DateTime argument, string name)
        {
            if (argument < DateTime.Parse("01/01/1970"))
                throw new CustomValidationException(String.Format(EntityMessage.InvalidDateArgument, name));
        }

        public static void ArgumentTrue(bool argument, string name)
        {
            if (argument == false)
                throw new CustomValidationException(String.Format(EntityMessage.FalseArgument, name));
        }
    }

    public class CustomValidationException : Exception
    {
        public CustomValidationException(object format)
        {
        }
    }
}
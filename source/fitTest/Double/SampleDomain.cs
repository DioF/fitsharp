// Copyright � 2011 Syterra Software Inc.
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License version 2.
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

using System;
using System.Collections.Generic;
using System.Linq;
using fitlibrary.tree;
using fitSharp.Samples;

namespace fit.Test.Double {
    public class SampleDomain {
        public SampleDomain() {}
        public SampleDomain(string theName) {
            Name = theName;
        }
        public string Name;
        public string Message;
        public int IntegerField;
        public int another_field;
        public string StringField;
        public DateTime DateTimeField;
        public Person PersonField;
        public string NewName;
        public string[] Strings;

        public static string StaticMethod() {
            return "hello";
        }

        public string ThrowException() {
            if (Message == "OK") return Message;
            if (Message == null) throw new NullReferenceException();
            throw new ApplicationException(Message);
        }

        public string Throw(string message) {
            if (message == null) throw new NullReferenceException();
            if (message == "OK") return message;
            throw new ApplicationException(message);
        }

        public void AddDays(int days) { DateTimeField = DateTimeField.AddDays(days); }

        public Tree MakeTree(string[] leaves) {
            return new SampleTree(string.Empty, leaves.Length == 1 && leaves[0].Length == 0 ? new string[] {} : leaves);
        }

        public IEnumerable<Person> GetPeople(string[] names) {
            return names.Select(n => {
                var split = n.Split('-');
                return new Person(split[0], split[1]);
            });
        }
    }

    public class another_sample_domain {}
}
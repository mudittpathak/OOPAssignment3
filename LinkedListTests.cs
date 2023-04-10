using Assignment_3_skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Test_Assignment_3
{
    public class LinkedListTests
    {
        private LinkedListADT linkedList;

        [SetUp]
        public void Setup()
        {
            // Create your concrete linked list class and assign to to linkedList.
            this.linkedList = new SLL();
        }

        [TearDown]
        public void TearDown()
        {
            this.linkedList.Clear();
        }

        //Test the linked list is empty.
        [Test]
        public void TestIsEmpty()
        {
            Assert.True(this.linkedList.IsEmpty());
            Assert.That(this.linkedList.Size(), Is.EqualTo(0));
        }

        //Tests appending elements to the linked list.
        [Test]
        public void TestAppendNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.That(this.linkedList.Size(), Is.EqualTo(4));

            // Test the first node value is a
            Assert.That(this.linkedList.Retrieve(0), Is.EqualTo("a"));

            // Test the second node value is b
            Assert.That(this.linkedList.Retrieve(1), Is.EqualTo("b"));

            // Test the third node value is c
            Assert.That(this.linkedList.Retrieve(2), Is.EqualTo("c"));

            // Test the fourth node value is d
            Assert.That(this.linkedList.Retrieve(3), Is.EqualTo("d"));
        }

        //Tests prepending nodes to linked list.
        [Test]
        public void testPrependNodes()
        {
            this.linkedList.Prepend("a");
            this.linkedList.Prepend("b");
            this.linkedList.Prepend("c");
            this.linkedList.Prepend("d");

            /**
             * Linked list should now be:
             * 
             * d -> c -> b -> a
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.That(this.linkedList.Size(), Is.EqualTo(4));

            // Test the first node value is a
            Assert.That(this.linkedList.Retrieve(0), Is.EqualTo("d"));

            // Test the second node value is b
            Assert.That(this.linkedList.Retrieve(1), Is.EqualTo("c"));

            // Test the third node value is c
            Assert.That(this.linkedList.Retrieve(2), Is.EqualTo("b"));

            // Test the fourth node value is d
            Assert.That(this.linkedList.Retrieve(3), Is.EqualTo("a"));
        }

        //Tests inserting node at valid index.
        [Test]
        public void TestInsertNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Insert("e", 2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.That(this.linkedList.Size(), Is.EqualTo(5));

            // Test the first node value is a
            Assert.That(this.linkedList.Retrieve(0), Is.EqualTo("a"));

            // Test the second node value is b
            Assert.That(this.linkedList.Retrieve(1), Is.EqualTo("b"));

            // Test the third node value is e
            Assert.That(this.linkedList.Retrieve(2), Is.EqualTo("e"));

            // Test the third node value is c
            Assert.That(this.linkedList.Retrieve(3), Is.EqualTo("c"));

            // Test the fourth node value is d
            Assert.That(this.linkedList.Retrieve(4), Is.EqualTo("d"));
        }

        //Tests replacing existing nodes data.
        [Test]
        public void TestReplaceNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Replace("e", 2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.That(this.linkedList.Size(), Is.EqualTo(4));

            // Test the first node value is a
            Assert.That(this.linkedList.Retrieve(0), Is.EqualTo("a"));

            // Test the second node value is b
            Assert.That(this.linkedList.Retrieve(1), Is.EqualTo("b"));

            // Test the third node value is e
            Assert.That(this.linkedList.Retrieve(2), Is.EqualTo("e"));

            // Test the fourth node value is d
            Assert.That(this.linkedList.Retrieve(3), Is.EqualTo("d"));
        }

        //Tests deleting node from linked list.
        [Test]
        public void TestDeleteNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Delete(2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

			// Test the size is 4
			Assert.That(this.linkedList.Size(), Is.EqualTo(3));

			// Test the first node value is a
			Assert.That(this.linkedList.Retrieve(0), Is.EqualTo("a"));

            // Test the second node value is b
            Assert.That(this.linkedList.Retrieve(1), Is.EqualTo("b"));

            // Test the fourth node value is d
            Assert.That(this.linkedList.Retrieve(2), Is.EqualTo("d"));
        }

        //Tests finding and retrieving node in linked list.
        [Test]
        public void TestFindNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            bool contains = this.linkedList.Contains("b");
            Assert.True(contains);

            int index = this.linkedList.IndexOf("b");
            Assert.That(index, Is.EqualTo(1));

            string value = (string)this.linkedList.Retrieve(1);
            Assert.That(value, Is.EqualTo("b"));
		}

		//Tests to get an item at an index in the linked list.
		[Test]
		public void TestRetrieveNode()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");

			/**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

			int iSize = this.linkedList.Size();
			Assert.That(iSize, Is.EqualTo(4));

			string value1 = (string)this.linkedList.Retrieve(1);
			Assert.That(value1, Is.EqualTo("b"));

			string value2 = (string)this.linkedList.Retrieve(3);
			Assert.That(value2, Is.EqualTo("d"));

			int fSize = this.linkedList.Size();
			Assert.That(fSize, Is.EqualTo(4));
		}

		//Tests to get the index of an item in the linked list.
		[Test]
		public void TestIndexOfNode()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");

			/**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

			int index1 = this.linkedList.IndexOf("a");
			Assert.That(index1, Is.EqualTo(0));

			int index2 = this.linkedList.IndexOf("b");
			Assert.That(index2, Is.EqualTo(1));

			int index3 = this.linkedList.IndexOf("d");
			Assert.That(index3, Is.EqualTo(3));

			int fSize = this.linkedList.Size();
			Assert.That(fSize, Is.EqualTo(4));
		}

		//Tests to check if the linked list has an item.
		[Test]
		public void TestContainsNode()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");

			/**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

			Assert.True(this.linkedList.Contains("a"));

			Assert.True(this.linkedList.Contains("b"));

			Assert.True(this.linkedList.Contains("d"));
			
			Assert.False(this.linkedList.Contains("e"));

			int fSize = this.linkedList.Size();
			Assert.That(fSize, Is.EqualTo(4));
		}

		//Tests to clear all items in the linked list
		[Test]
		public void TestClearNodes()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");
			this.linkedList.Append("d");

			/**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

			int iSize = this.linkedList.Size();
			Assert.That(iSize, Is.EqualTo(4));

			this.linkedList.Clear();

			int fSize = this.linkedList.Size();
			Assert.That(fSize, Is.EqualTo(0));
		}

		//Tests to get the number of items in the linked list.
		[Test]
		public void TestSizeNodes()
		{
			int iSize = this.linkedList.Size();
			Assert.That(iSize, Is.EqualTo(0));
			
			this.linkedList.Append("a");
			this.linkedList.Append("b");

			/**
             * Linked list should now be:
             * 
             * a -> b
             */

			int mSize = this.linkedList.Size();
			Assert.That(mSize, Is.EqualTo(2));


			this.linkedList.Append("c");
			this.linkedList.Append("d");

			/**
             * Linked list should now be:
             *  
             * a -> b -> c -> d
             */

			int fSize = this.linkedList.Size();
			Assert.That(fSize, Is.EqualTo(4));
		}
	}
}

#include "pch.h"
#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace ConsoleApplication1TestsStory
{
	TEST_CLASS(ConsoleApplication1TestsStory)
	{
	public:
		
		TEST_METHOD(TestDevelop)
		{
			auto expected = "test";

			auto actual = expected;

			Assert::AreEqual(expected, actual);
		}
	};
}

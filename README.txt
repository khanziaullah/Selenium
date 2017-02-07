# Selenium

I am trying out multiple examples of Selenium to better understand the features and functionalities offered.

#WebDriverDemo 
This is an example project. 

1. It uses FirefoxDriver and FirefoxDriverService classes to spin off an instance of firefox and launch google.com.
2. Interacts with the page by finding elements.
  a. ClassName might return multiple elements, index to get to the right element.
  b.  CssSelector
  c. Id - most preferred, cause it gives a single name
  d. LinkText
  e. PartialLinkText 
  f. Name
  g. TagName
  h. XPath - Last option

3. Added Example for Radio button.
  Created a temporary HTML page with simple HTML code for rendering a couple of radio buttons.
  The code finds multiple element by name and randomly choses the 2nd element and calls function click. That selects the radio button.

4. Added Example for Select element.
  An actual real life example test that validates that an option is selected
  Another example that tells about the selenium UI support library. This example tells how to use different options. I am using SelectElementByValue.

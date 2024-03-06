function truncate(str, maxlength) {
    // Check if the length of the string exceeds maxlength
    if (str.length > maxlength) {
      // Truncate the string and add ellipsis at the end
      return str.slice(0, maxlength - 3) + '...';
    }
    
    // If the length is within the limit, return the original string
    return str;
  }
  
  // Test cases
  console.log(truncate("What I'd like to tell on this topic is:", 20)); // "What I'd like to te..."
  console.log(truncate("Hi everyone!", 20)); // "Hi everyone!"
  
function checkEmailId(str) {
    // Convert the string to lowercase for case-insensitive comparison
    str = str.toLowerCase();
  
    // Check if the string contains '@' and '.'
    if (str.includes('@') && str.includes('.')) {
      // Find the indices of '@' and '.'
      let atIndex = str.indexOf('@');
      let dotIndex = str.indexOf('.');
  
      // Check if '@' comes before '.' and there are characters between them
      if (atIndex < dotIndex && dotIndex - atIndex > 1) {
        return true;
      }
    }
    
    return false;
  }
  
  // Test cases
  console.log(checkEmailId('example@email.com')); // true
  console.log(checkEmailId('user.123@gmail')); // false
  console.log(checkEmailId('user@yahoo.co.in')); // true
  console.log(checkEmailId('noatsymbol.com')); // false
  console.log(checkEmailId('noatsymbol@com')); // false
  
class Solution:
    def isPalindrome(self, x: int) -> bool:
        y=x
        z=0
        
        while(x>0):
            z = (int)(z*10 + x%10)
            x = (int)(x/10)

        if y==z:
            return True
        else:
            return False   
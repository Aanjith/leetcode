class Solution(object):
    def canJump(self, nums):
        """
        :type nums: List[int]
        :rtype: bool
        """
        flag=True
        CI=len(nums)-1
        if len(nums)==0:
                return True
        for i in range(CI,-1,-1):
            if(nums[i]<CI-i):
                flag=False
            elif(nums[i]>=CI-i):
                flag=True
                if CI==0:
                    break
                else:
                    CI=i
        return flag
            

        
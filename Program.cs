//*****************************************************************************
//** 2044. Count Number of Maximum Bitwise-OR Subsets    leetcode            **
//*****************************************************************************


int countMaxOrSubsets(int* nums, int numsSize) {
    int totalSubsets = 1 << numsSize;  // 2^n subsets
    int maxOr = 0;
    int count = 0;
    
    // Calculate the maximum OR value
    for (int i = 0; i < numsSize; i++) {
        maxOr |= nums[i];  // This will be the maximum OR possible
    }
    
    // Iterate through all subsets
    for (int subsetMask = 1; subsetMask < totalSubsets; ++subsetMask) {
        int currentOr = 0;
        
        // Calculate OR for this subset
        for (int i = 0; i < numsSize; i++) {
            if (subsetMask & (1 << i)) {
                currentOr |= nums[i];
            }
        }
        
        // If the current OR equals the maximum OR, count this subset
        if (currentOr == maxOr) {
            count++;
        }
    }
    
    return count;
}
class XorLogic {
    
    public static bool Logic(bool x, bool y)
    {
        bool answer;

        bool not_x = !x;

        bool xor_x = not_x ^ x;

        bool and_xy = xor_x && y;

        answer =! and_xy;

        return answer;
    }
}
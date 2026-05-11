using System.Collections;
using System.Collections.Generic;
using System;

namespace Assignment2.Events {
    public static class EventManager {
        // حدث عند زيادة النقاط أو موت عدو
        public static Action<int> OnScoreChanged;
        
        public static void TriggerScoreChanged(int points) {
            OnScoreChanged?.Invoke(points);
        }
    }
}

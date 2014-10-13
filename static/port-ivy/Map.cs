public class Map : RMUD.MudObject {
    public override void Initialize() {
        Short = "map of Port Ivy";
        Nouns.Add("port", "ivy", "map", "of");
        Long =
            @"Port Ivy - The Island

    ·-·-·-·-·-·                  o: Cathedral                          
   /   /       \                 1: Bed And Breakfast                          
  · 1-M-0       ·-·              2: Lighthouse                          
   \  A            \                                       
    · I             ·-·                                    
    | N               |                                    
    · |-CRESCENT      ·-·                                  
   /  S          S       \                                 
2 ·   T           T       B                                
 \|   R           R      E                                 
  ·-·-E       EET-E-·-·-A                                  
  |   E      R    E     C                                  
  D   T     T     T     H                                  
  O   |    S      |     |                                  
  C-·-DOCK        ·     ·                                  
   K   \         /     /                                   
    S-·-·       ·     ·                                    
    |    \     /     /                                     
    WATER ·-·-· ·-·-·                                      
         P     /                                           
          ARK-·               
";
    }
}

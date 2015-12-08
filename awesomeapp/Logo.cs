using System;
namespace AwesomeApp
{
	public static class Logo {
    private const string _placeholder = "{                                                           }";
		private static string _content = @"
                                                 .......                                           
                                      .(%%%%%%%%%%%%%%%%%%%%%%%%%/                                 
                                 ,%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#.                           
                             ,%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%.                       
                          /%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%,                    
                       ,%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%                  
                     (%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*               
                   #%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/             
                 (%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%,           
               .%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%          
              #%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/        
             %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%       
           .%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%      
          .%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%     
         .%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%    
         %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%   
        %%%%%%%%%%*     #%%%%%%%%    /%%%%            /%.                %%%%%%%%%%%%%%%%%%%%%%%/  
       ,%%%%%%%%%%*      *%%%%%%%    /%%%%            /%.                %%%%%%%%%%%%%%%%%%%%%%%%  
       %%%%%%%%%%%*        %%%%%%    /%%%%     %%%%%%%%%%%%%%%     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%# 
      .%%%%%%%%%%%*    .    #%%%%    /%%%%     %%%%%%%%%%%%%%%     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% 
           #%%%%%%*    %(    /%%%    /%%%%            %%%%%%%%     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%,
  .(((((((   %%%%%*    %%%    .%%    /%%%%            %%%%%%%%     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#
 ((((((((((*  %%%%*    %%%%.    %    /%%%%     %%%%%%%%%%%%%%%     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
*(((((((((((  *%%%*    %%%%%/        /%%%%     %%%%%%%%%%%%%%%     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
,(((((((((((  (%%%*    %%%%%%%       /%%%%     %%%%%%%%%%%%%%%     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
 *(((((((((  .%%%%*    %%%%%%%%      /%%%%             %%%%%%%     %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#
   .((((/   (%%%%%/....%%%%%%%%%/....(%%%%,............%%%%%%%,....%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(
        .(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%.
       %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% 
       #%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/ 
        %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  
        /%%%%%%%%%.                                                                 %%%%%%%%%%%%.  
         #%%%%%%%%.  {                                                           }  %%%%%%%%%%%/   
          %%%%%%%%.                                                                 %%%%%%%%%%#    
           %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#     
            %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(      
             (%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%,       
              .%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%         
                #%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%*          
                  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#            
                    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#              
                      #%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%/                
                        ,%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%.                  
                           *%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%.                     
                               #%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%(                         
                                   *%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#,                             
                                         ,(%%%%%%%%%%%%%%%%%%#/.";

		public static string Draw(string OS){
      var text = $".NET Core <3 {OS}";
      var label = text.PadRight(_placeholder.Length);
      var logo = _content.Replace(_placeholder, label);
      
			return logo;
		}
	}

}
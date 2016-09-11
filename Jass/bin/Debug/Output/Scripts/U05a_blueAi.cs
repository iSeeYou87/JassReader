using System;
using System.Collections.Generic;

namespace Jass {

	public class U05a_blueAi {

		//
		//
		//
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ELF_FARM,null);//call CampaignAI(ELF_FARM,null)
			SetReplacements(0,1,3);//call SetReplacements(0,1,3)
			SetBuildUnitEx(0,0,1, TOWN_HALL);//call SetBuildUnitEx( 0,0,1, TOWN_HALL			)
			SetBuildUnitEx(2,2,2, PEASANT);//call SetBuildUnitEx( 2,2,2, PEASANT				)
			SetBuildUnitEx(0,0,2, ELF_HIGH_BARRACKS);//call SetBuildUnitEx( 0,0,2, ELF_HIGH_BARRACKS	)
			SetBuildUnitEx(0,0,13, ELF_FARM);//call SetBuildUnitEx( 0,0,13, ELF_FARM			)
			SetBuildUnitEx(0,0,1, LUMBER_MILL);//call SetBuildUnitEx( 0,0,1, LUMBER_MILL			)
			SetBuildUnitEx(5,5,5, PEASANT);//call SetBuildUnitEx( 5,5,5, PEASANT				)
			SetBuildUnitEx(0,0,1, BLACKSMITH);//call SetBuildUnitEx( 0,0,1, BLACKSMITH			)
			SetBuildUnitEx(0,0,1, HUMAN_ALTAR);//call SetBuildUnitEx( 0,0,1, HUMAN_ALTAR			)
			SetBuildUnitEx(0,0,1, KEEP);//call SetBuildUnitEx( 0,0,1, KEEP				)
			SetBuildUnitEx(0,0,1, SANCTUM);//call SetBuildUnitEx( 0,0,1, SANCTUM				)
			SetBuildUnitEx(0,0,1, CASTLE);//call SetBuildUnitEx( 0,0,1, CASTLE				)
			CampaignDefenderEx(1,1,3, HIGH_SWORDMAN);//call CampaignDefenderEx( 1,1,3, HIGH_SWORDMAN   )
			CampaignDefenderEx(1,1,4, HIGH_ARCHER);//call CampaignDefenderEx( 1,1,4, HIGH_ARCHER     )
			CampaignDefenderEx(0,0,1, PRIEST);//call CampaignDefenderEx( 0,0,1, PRIEST          )
			CampaignDefenderEx(0,1,1, SORCERESS);//call CampaignDefenderEx( 0,1,1, SORCERESS       )
			CampaignDefenderEx(0,0,1, SYLVANUS);//call CampaignDefenderEx( 0,0,1, SYLVANUS	    )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2, HIGH_SWORDMAN);//call CampaignAttackerEx( 1,1,2, HIGH_SWORDMAN   )
			CampaignAttackerEx(1,2,4, HIGH_ARCHER);//call CampaignAttackerEx( 1,2,4, HIGH_ARCHER     )
			SuicideOnPlayer(0,user);//call SuicideOnPlayer(0,user)
			SetBuildUpgrEx(0,1,1, UPG_SORCERY);//call SetBuildUpgrEx( 0,1,1, UPG_SORCERY    )
			SetBuildUpgrEx(0,1,1, UPG_PRAYING);//call SetBuildUpgrEx( 0,1,1, UPG_PRAYING    )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,3, HIGH_SWORDMAN);//call CampaignAttackerEx( 1,1,3, HIGH_SWORDMAN   )
			CampaignAttackerEx(2,3,3, HIGH_ARCHER);//call CampaignAttackerEx( 2,3,3, HIGH_ARCHER     )
			CampaignAttackerEx(0,1,1, SYLVANUS);//call CampaignAttackerEx( 0,1,1, SYLVANUS        )
			SuicideOnPlayerEx(M5,M4,M3,user);//call SuicideOnPlayerEx(M5,M4,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(0,1,4, HIGH_SWORDMAN);//call CampaignAttackerEx( 0,1,4, HIGH_SWORDMAN   )
			CampaignAttackerEx(2,3,4, HIGH_ARCHER);//call CampaignAttackerEx( 2,3,4, HIGH_ARCHER     )
			CampaignAttackerEx(1,1,1, PRIEST);//call CampaignAttackerEx( 1,1,1, PRIEST          )
			CampaignAttackerEx(0,0,1, SORCERESS);//call CampaignAttackerEx( 0,0,1, SORCERESS       )
			CampaignAttackerEx(0,1,2, BALLISTA);//call CampaignAttackerEx( 0,1,2, BALLISTA        )
			SuicideOnPlayerEx(M5,M4,M2,user);//call SuicideOnPlayerEx(M5,M4,M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,4,4, HIGH_SWORDMAN);//call CampaignAttackerEx( 2,4,4, HIGH_SWORDMAN   )
			CampaignAttackerEx(2,2,4, HIGH_ARCHER);//call CampaignAttackerEx( 2,2,4, HIGH_ARCHER     )
			CampaignAttackerEx(0,1,1, PRIEST);//call CampaignAttackerEx( 0,1,1, PRIEST          )
			CampaignAttackerEx(1,1,1, SYLVANUS);//call CampaignAttackerEx( 1,1,1, SYLVANUS        )
			SuicideOnPlayerEx(M5,M4,M3,user);//call SuicideOnPlayerEx(M5,M4,M3,user)
			SetBuildUpgrEx(0,0,2, UPG_SORCERY);//call SetBuildUpgrEx( 0,0,2, UPG_SORCERY     )
			SetBuildUpgrEx(0,0,2, UPG_PRAYING);//call SetBuildUpgrEx( 0,0,2, UPG_PRAYING     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,3,4, HIGH_SWORDMAN);//call CampaignAttackerEx( 2,3,4, HIGH_SWORDMAN   )
			CampaignAttackerEx(1,3,4, HIGH_ARCHER);//call CampaignAttackerEx( 1,3,4, HIGH_ARCHER     )
			CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST          )
			CampaignAttackerEx(0,0,1, SORCERESS);//call CampaignAttackerEx( 0,0,1, SORCERESS       )
			CampaignAttackerEx(0,0,1, SYLVANUS);//call CampaignAttackerEx( 0,0,1, SYLVANUS        )
			CampaignAttackerEx(0,1,2, BALLISTA);//call CampaignAttackerEx( 0,1,2, BALLISTA        )
			SuicideOnPlayerEx(M6,M4,M2,user);//call SuicideOnPlayerEx(M6,M4,M2,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,2,2, HIGH_SWORDMAN);//call CampaignAttackerEx( 1,2,2, HIGH_SWORDMAN)
				CampaignAttackerEx(3,5,7, HIGH_ARCHER);//call CampaignAttackerEx( 3,5,7, HIGH_ARCHER  )
				CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST       )
				CampaignAttackerEx(0,1,1, SORCERESS);//call CampaignAttackerEx( 0,1,1, SORCERESS    )
				CampaignAttackerEx(1,1,1, SYLVANUS);//call CampaignAttackerEx( 1,1,1, SYLVANUS     )
				SuicideOnPlayerEx(M5,M4,M3,user);//call SuicideOnPlayerEx(M5,M4,M3,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,4,8, HIGH_SWORDMAN);//call CampaignAttackerEx( 3,4,8, HIGH_SWORDMAN)
				CampaignAttackerEx(0,2,2, HIGH_ARCHER);//call CampaignAttackerEx( 0,2,2, HIGH_ARCHER  )
				CampaignAttackerEx(1,3,4, PRIEST);//call CampaignAttackerEx( 1,3,4, PRIEST       )
				CampaignAttackerEx(0,0,1, SORCERESS);//call CampaignAttackerEx( 0,0,1, SORCERESS    )
				CampaignAttackerEx(0,1,2, BALLISTA);//call CampaignAttackerEx( 0,1,2, BALLISTA     )
				SuicideOnPlayerEx(M6,M4,M2,user);//call SuicideOnPlayerEx(M6,M4,M2,user)
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(2,2,5, HIGH_SWORDMAN);//call CampaignAttackerEx( 2,2,5, HIGH_SWORDMAN)
				CampaignAttackerEx(1,3,3, HIGH_ARCHER);//call CampaignAttackerEx( 1,3,3, HIGH_ARCHER  )
				CampaignAttackerEx(1,1,2, PRIEST);//call CampaignAttackerEx( 1,1,2, PRIEST       )
				CampaignAttackerEx(1,2,4, SORCERESS);//call CampaignAttackerEx( 1,2,4, SORCERESS    )
				CampaignAttackerEx(0,1,1, SYLVANUS);//call CampaignAttackerEx( 0,1,1, SYLVANUS     )
				SuicideOnPlayerEx(M6,M4,M3,user);//call SuicideOnPlayerEx(M6,M4,M3,user)
			}//endloop
		}//endfunction

	
	}
}

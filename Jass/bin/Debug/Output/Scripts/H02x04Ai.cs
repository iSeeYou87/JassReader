using System;
using System.Collections.Generic;

namespace Jass {

	public class H02x04Ai {

		//
		//
		//
		//
		//
		//
		private void after_expand() {//function after_expand takes nothing returns nothing
			//
			//
			SetBuildUpgrEx(1,1,1, UPG_BLK_SPHINX);//call SetBuildUpgrEx( 1,1,1, UPG_BLK_SPHINX      )
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_STR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_STR      )
			SetBuildUpgrEx(2,2,3, UPG_CR_ATTACK);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ATTACK       )
			SetBuildUpgrEx(2,2,3, UPG_UNHOLY_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_UNHOLY_ARMOR    )
			SetBuildUpgrEx(2,2,3, UPG_CR_ARMOR);//call SetBuildUpgrEx( 2,2,3, UPG_CR_ARMOR        )
			SetBuildUpgrEx(1,1,1, UPG_FIEND_WEB);//call SetBuildUpgrEx( 1,1,1, UPG_FIEND_WEB       )
			SetBuildUpgrEx(0,0,1, UPG_PLAGUE);//call SetBuildUpgrEx( 0,0,1, UPG_PLAGUE          )
			SetBuildUpgrEx(1,1,1, UPG_GHOUL_FRENZY);//call SetBuildUpgrEx( 1,1,1, UPG_GHOUL_FRENZY    )
			SetBuildUpgrEx(1,1,1, UPG_EXHUME);//call SetBuildUpgrEx( 1,1,1, UPG_EXHUME          )
			SetBuildUpgrEx(1,1,1, UPG_WYRM_BREATH);//call SetBuildUpgrEx( 1,1,1, UPG_WYRM_BREATH     )
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,2, ABOMINATION);//call CampaignAttackerEx( 1,1,2, ABOMINATION )
			CampaignAttackerEx(4,4,6, GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL       )
			SuicideOnPlayerEx(M2,M2,M2,user);//call SuicideOnPlayerEx(M2,M2,M2,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(2,2,7, GARGOYLE);//call CampaignAttackerEx( 2,2,7, GARGOYLE    )
			CampaignAttackerEx(1,1,2, FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
			CampaignAttackerEx(1,1,3, BLK_SPHINX);//call CampaignAttackerEx( 1,1,3, BLK_SPHINX  )
			SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(1,1,1, DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD  )
			CampaignAttackerEx(4,4,6, GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL       )
			CampaignAttackerEx(2,2,3, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,3, CRYPT_FIEND )
			CampaignAttackerEx(1,1,2, MEAT_WAGON);//call CampaignAttackerEx( 1,1,2, MEAT_WAGON  )
			SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,8, GARGOYLE);//call CampaignAttackerEx( 3,3,8, GARGOYLE    )
				CampaignAttackerEx(2,2,4, BLK_SPHINX);//call CampaignAttackerEx( 2,2,4, BLK_SPHINX  )
				SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(1,1,1, DREAD_LORD);//call CampaignAttackerEx( 1,1,1, DREAD_LORD  )
				CampaignAttackerEx(3,3,5, ABOMINATION);//call CampaignAttackerEx( 3,3,5, ABOMINATION )
				CampaignAttackerEx(1,1,2, BLK_SPHINX);//call CampaignAttackerEx( 1,1,2, BLK_SPHINX  )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,8, GARGOYLE);//call CampaignAttackerEx( 3,3,8, GARGOYLE    )
				CampaignAttackerEx(1,1,2, FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
				CampaignAttackerEx(1,1,3, BLK_SPHINX);//call CampaignAttackerEx( 1,1,3, BLK_SPHINX  )
				SuicideOnPlayerEx(M4,M4,M3,user);//call SuicideOnPlayerEx(M4,M4,M3,user)
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,6, GHOUL);//call CampaignAttackerEx( 4,4,6, GHOUL       )
				CampaignAttackerEx(2,2,3, ABOMINATION);//call CampaignAttackerEx( 2,2,3, ABOMINATION )
				CampaignAttackerEx(2,2,3, CRYPT_FIEND);//call CampaignAttackerEx( 2,2,3, CRYPT_FIEND )
				CampaignAttackerEx(1,1,1, MEAT_WAGON);//call CampaignAttackerEx( 1,1,1, MEAT_WAGON  )
				CampaignAttackerEx(0,0,1, DREAD_LORD);//call CampaignAttackerEx( 0,0,1, DREAD_LORD  )
				SuicideOnPlayerEx(M5,M5,M4,user);//call SuicideOnPlayerEx(M5,M5,M4,user)
			}//endloop
		}//endfunction
		//
		//
		//
		private void test_expand() {//function test_expand takes nothing returns nothing
			if (CommandsWaiting() > 0) {//if CommandsWaiting() > 0 then
				after_expand();//call after_expand()
			}//endif
		}//endfunction
		//
		//
		//
		private void main() {//function main takes nothing returns nothing
			CampaignAI(ZIGGURAT_1,null);//call CampaignAI(ZIGGURAT_1,null)
			DoCampaignFarms(false);//call DoCampaignFarms(false)
			SetRandomPaths(false);//call SetRandomPaths(false)
			SetReplacements(2,2,3);//call SetReplacements(2,2,3)
			SetWoodPeons(2);//call SetWoodPeons(2)
			SetBuildUnitEx(2,2,2, UNDEAD_BARGE);//call SetBuildUnitEx( 2,2,2, UNDEAD_BARGE    )
			SetBuildUnitEx(5,5,5, ACOLYTE);//call SetBuildUnitEx( 5,5,5, ACOLYTE         )
			SetBuildUpgrEx(1,1,1, UPG_BLK_SPHINX);//call SetBuildUpgrEx( 1,1,1, UPG_BLK_SPHINX  )
			CampaignDefenderEx(0,0,1, DREAD_LORD);//call CampaignDefenderEx( 0,0,1, DREAD_LORD  )
			CampaignDefenderEx(1,1,2, ABOMINATION);//call CampaignDefenderEx( 1,1,2, ABOMINATION )
			CampaignDefenderEx(1,1,1, BLK_SPHINX);//call CampaignDefenderEx( 1,1,1, BLK_SPHINX  )
			CampaignDefenderEx(0,0,1, GARGOYLE);//call CampaignDefenderEx( 0,0,1, GARGOYLE    )
			CampaignDefenderEx(0,0,1, CRYPT_FIEND);//call CampaignDefenderEx( 0,0,1, CRYPT_FIEND )
			CampaignDefenderEx(1,1,1, OBS_STATUE);//call CampaignDefenderEx( 1,1,1, OBS_STATUE  )
			WaitForSignal();//call WaitForSignal()
			//
			InitAssaultGroup();//call InitAssaultGroup()
			CampaignAttackerEx(3,3,5, GARGOYLE);//call CampaignAttackerEx( 3,3,5, GARGOYLE    )
			SuicideOnPlayerEx(20,20,20,user);//call SuicideOnPlayerEx(20,20,20,user)
			test_expand();//call test_expand()
			while (true) {//loop
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(3,3,7, GARGOYLE);//call CampaignAttackerEx( 3,3,7, GARGOYLE    )
				CampaignAttackerEx(1,1,2, FROST_WYRM);//call CampaignAttackerEx( 1,1,2, FROST_WYRM  )
				SuicideOnPlayerEx(M2,M2,M2,user);//call SuicideOnPlayerEx(M2,M2,M2,user)
				test_expand();//call test_expand()
				//
				InitAssaultGroup();//call InitAssaultGroup()
				CampaignAttackerEx(4,4,7, GARGOYLE);//call CampaignAttackerEx( 4,4,7, GARGOYLE    )
				CampaignAttackerEx(0,0,1, BLK_SPHINX);//call CampaignAttackerEx( 0,0,1, BLK_SPHINX  )
				SuicideOnPlayerEx(M2,M2,M2,user);//call SuicideOnPlayerEx(M2,M2,M2,user)
				test_expand();//call test_expand()
			}//endloop
		}//endfunction

	
	}
}

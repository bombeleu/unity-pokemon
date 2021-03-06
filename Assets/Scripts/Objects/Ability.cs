﻿using System;
using System.Collections.Generic;

public class Ability {
	public static Dictionary<int,Ability> ABILITIES;
	public int id;
	public string name, description;
	public int battle_effect_id, world_effect_id;
	public Effect world_effect, battle_effect;
	
	private Ability(){}
	public static void init(List<Dictionary<string,string>> ability_defs) {
		ABILITIES = new Dictionary<int, Ability> (ability_defs.Count);
		foreach (Dictionary<string,string> row in ability_defs) {
		    Ability temp = new Ability();
			temp.id = Convert.ToInt32(row["id"]);
			temp.name = row["name"];
			temp.description = row["description"];
			temp.battle_effect_id = Convert.ToInt32(row["battle_effect_id"]);
			temp.world_effect_id = Convert.ToInt32(row["world_effect_id"]);
			ABILITIES[temp.id] = temp;
		}
	}
	public static void link() {
	    foreach (Ability temp in ABILITIES.Values) {
	        temp.world_effect = Effect.EFFECTS[temp.world_effect_id];
	        temp.battle_effect = Effect.EFFECTS[temp.battle_effect_id];
	    }
	}
}

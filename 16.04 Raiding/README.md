
# 4. Raiding

Your task is to create a class hierarchy like the one shown here:

![image info](pic./Picture1.png)

The **BaseHero** class should be **abstract** and inherit from **IHero**.

- **BaseHero – abstract – has string Name, abstract int Power, virtual string CastAbility():** **\{this.GetType().Name} - \{this.Name}**
- **Fighter – abstract – inherits BaseHero, overrides CastAbility(): \{base.CastAbility()} hit for \{this.Power} damage**
- **Healer – abstract – inherits BaseHero, overrides CastAbility(): \{base.CastAbility()} healed for \{this.Power}**

Now create concrete classes:

  - **Druid – inherits Healer, overrides power = 80, overrides CastAbility(): \{base.CastAbility()}**
  - **Paladin – inherits Healer, overrides power = 100, overrides CastAbility(): \{base.CastAbility()}**
  - **Rogue – inherits Fighter, overrides power = 80, overrides CastAbility(): \{base.CastAbility()}**
  - **Warrior – inherits Fighter, overrides power = 100, overrides CastAbility(): \{base.CastAbility()}**

## Example

| **Input** | **Output** |
| --- | --- |
| 3<br>Mike<br>Paladin<br>Josh<br>Druid<br>Scott<br>Warrior<br>250 | Paladin - Mike healed for 100<br>Druid - Josh healed for 80<br>Warrior - Scott hit for 100 damage<br>Victory! |
| 2<br>Mike<br>Warrior<br>Tom<br>Rogue<br>200 | Warrior - Mike hit for 100 damage<br>Rogue - Tom hit for 80 damage<br>Defeat... |

![Shape1](RackMultipart20231208-1-zuc0lv_html_1c4878c41f6f4b07.gif)

© SoftUni – [https://softuni.org](https://softuni.org/). Copyrighted document. Unauthorized copy, reproduction or use is not permitted.

[![](RackMultipart20231208-1-zuc0lv_html_9b17934bfedeb713.png)](https://softuni.org/)[![](RackMultipart20231208-1-zuc0lv_html_c9db196993f48ff8.png)](https://softuni.bg/)[![Software University @ Facebook](RackMultipart20231208-1-zuc0lv_html_94be3df36d913358.png)](https://www.facebook.com/softuni.org)[![](RackMultipart20231208-1-zuc0lv_html_7e8e605369b4ad74.png)](https://www.instagram.com/softuni_org)[![Software University @ Twitter](RackMultipart20231208-1-zuc0lv_html_ff9c629b0a21eb6b.png)](https://twitter.com/SoftUni1)[![Software University @ YouTube](RackMultipart20231208-1-zuc0lv_html_7db86a748da0e575.png)](https://www.youtube.com/channel/UCqvOk8tYzfRS-eDy4vs3UyA)[![](RackMultipart20231208-1-zuc0lv_html_95554caa563bbdb3.png)](https://www.linkedin.com/company/softuni/)[![](RackMultipart20231208-1-zuc0lv_html_4df51bfadcab813.png)](https://github.com/SoftUni)[![Software University: Email Us](RackMultipart20231208-1-zuc0lv_html_d7fa82ab7332f3fa.png)](mailto:info@softuni.org)

Follow us:

Page 2 of 2

[![](RackMultipart20231208-1-zuc0lv_html_3aa486326bfa75e9.png)](https://softuni.org/)
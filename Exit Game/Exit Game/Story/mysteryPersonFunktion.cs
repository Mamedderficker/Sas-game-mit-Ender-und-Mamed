using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_adventures.Story
{
    internal class MysteryPersonFunktion
    {
        public static void StoryMysteryPerson()
        {
            Console.Clear();
            Console.WriteLine("\n🗣️ Ein mysteriöser Mann mit Kapuze spricht dich an...");
            Console.WriteLine("Mann: 'Ich kenne das Geheimnis des Dungeons von Eldoria...'");
            Console.WriteLine("Willst du zuhören? (ja/nein)");
            string dialogWahl = Console.ReadLine().ToLower();

            if (dialogWahl == "ja")
            {
                Console.WriteLine("\nMann: 'Geh nach Norden... dort beginnt dein wahres Abenteuer.'");
                Console.WriteLine("Mann: 'Doch sei gewarnt, du brauchst einen Schlüssel, um die Tore des Dungeons zu öffnen.'");
                Console.WriteLine("Möchtest du nach dem Schlüssel fragen? (ja/nein)");
                string schluesselWahl = Console.ReadLine().ToLower();

                if (schluesselWahl == "ja")
                {
                    Console.WriteLine("\nMann: 'Der Schlüssel befindet sich in der alten Ruine im Osten. Aber dort lauern Gefahren...'");
                    Console.WriteLine("Möchtest du dich sofort auf den Weg machen oder zuerst Informationen sammeln? (gehen/informationen)");
                    string ruineWahl = Console.ReadLine().ToLower();

                    if (ruineWahl == "gehen")
                    {
                        Console.WriteLine("\nDu machst dich entschlossen auf den Weg zur Ruine...");
                        // Hier könnte eine weitere Szene folgen
                    }
                    else if (ruineWahl == "informationen")
                    {
                        Console.WriteLine("\nMann: 'Ein uraltes Rätsel schützt den Schlüssel. Merke dir dies: Die Antwort liegt in der Zahl der Monde.'");
                        Console.WriteLine("\nDu hast eine wertvolle Information erhalten und machst dich auf den Weg zur Ruine...");
                    }
                }
                else
                {
                    Console.WriteLine("\nMann: 'Wie du willst... doch ohne den Schlüssel wirst du nicht weiterkommen.'");
                }
            }
            else
            {
                Console.WriteLine("\nMann: 'Deine Wahl... Doch bedenke, das Schicksal gibt selten eine zweite Chance.'");
            }
            static void ErkundenRuine()
            {
                Console.Clear();
                Console.WriteLine("\n🌙 Du erreichst die alte Ruine, umgeben von dichtem Nebel...");
                Console.WriteLine("Eine unheimliche Stille liegt in der Luft. Möchtest du eintreten? (ja/nein)");
                string ruinenWahl = Console.ReadLine().ToLower();

                if (ruinenWahl == "ja")
                {
                    Console.WriteLine("\nDu betrittst die Ruine und findest dich in einer großen Halle wieder.");
                    Console.WriteLine("An der Wand siehst du eine alte Inschrift mit einem Rätsel.");
                    Console.WriteLine("\nInschrift: 'Vier Monde erhellen die dunkle Nacht. Die Hälfte von ihnen verschwindet. Wie viele bleiben?'");
                    Console.Write("Antwort: ");
                    string antwort = Console.ReadLine();

                    if (antwort == "2")
                    {
                        Console.WriteLine("\nDie Inschrift beginnt zu leuchten, eine geheime Tür öffnet sich.");
                        Console.WriteLine("Hinter der Tür findest du eine alte Truhe mit einem goldenen Schlüssel.");
                        Console.WriteLine("Du hast den Schlüssel zum Dungeon von Eldoria erhalten!");
                    }
                    else
                    {
                        Console.WriteLine("\nPlötzlich beginnt der Boden zu beben, und eine Falle wird aktiviert!");
                        Console.WriteLine("Du musst schnell fliehen, bevor du gefangen wirst...");
                        // Weitere Flucht-Mechaniken können hier folgen
                    }
                }
                else
                {
                    Console.WriteLine("\nDu entscheidest dich, nicht in die Ruine einzutreten und kehrst um.");
                    Console.WriteLine("Doch ohne den Schlüssel wirst du den Dungeon von Eldoria nicht betreten können...");
                }
                static void BetreteDungeon()
                {
                    Console.Clear();
                    Console.WriteLine("\n🏰 Mit dem goldenen Schlüssel in der Hand stehst du vor den Toren des Dungeons von Eldoria.");
                    Console.WriteLine("Langsam öffnest du die massive Tür und betrittst die dunkle Kammer.");

                    Console.WriteLine("\nPlötzlich hörst du ein leises Zischen aus der Dunkelheit...");
                    Console.WriteLine("Eine Stimme hallt durch den Raum: 'Wer wagt es, den heiligen Boden zu betreten?'\n");
                    Console.WriteLine("Willst du antworten oder dich verstecken? (antworten/verstecken)");
                    string reaktion = Console.ReadLine().ToLower();

                    if (reaktion == "antworten")
                    {
                        Console.WriteLine("\nDu rufst mutig: 'Ich bin ein Abenteurer auf der Suche nach dem wahren Geheimnis dieses Ortes!'");
                        Console.WriteLine("Die Stimme lacht leise und eine Gestalt tritt aus dem Schatten hervor – ein alter Wächter der Ruinen.");
                        Console.WriteLine("Wächter: 'Nur wer die Prüfung der Schatten besteht, darf weitergehen...'");
                        Console.WriteLine("Er hebt seine Hand und plötzlich umgibt dich völlige Dunkelheit.");
                        Console.WriteLine("Eine geheimnisvolle Prüfung beginnt...\n");
                        // Hier könnte eine Prüfung oder ein Rätsel folgen
                    }
                    else if (reaktion == "verstecken")
                    {
                        Console.WriteLine("\nDu versuchst, dich in einer dunklen Ecke zu verbergen, aber die Stimme ruft erneut: 'Feigheit wird hier nicht belohnt!'");
                        Console.WriteLine("Plötzlich spürst du einen starken Luftzug – und ein unsichtbarer Stoß wirft dich zurück vor das Tor.");
                        Console.WriteLine("Es scheint, als müsstest du dich der Herausforderung stellen, um weiterzukommen...");
                    }
                    else
                    {
                        Console.WriteLine("\nDeine Unentschlossenheit kostet dich wertvolle Zeit. Der Raum beginnt, sich mit Schatten zu füllen...");
                        Console.WriteLine("Etwas Schreckliches nähert sich aus der Dunkelheit...");
                        Console.WriteLine("Du solltest dich schnell entscheiden!\n");
                    }
                }
                static void PruefungDerSchatten()
                {
                    Console.Clear();
                    Console.WriteLine("\n🌑 Die Dunkelheit umhüllt dich komplett. Du kannst nichts sehen, nur die Stimme des Wächters hören.");
                    Console.WriteLine("Wächter: 'Nur diejenigen, die ihre Ängste überwinden, werden die Wahrheit erkennen.'");
                    Console.WriteLine("Plötzlich erscheinen drei leuchtende Symbole vor dir. Ein Schwert ⚔, eine Laterne 🏮 und eine Maske 🎭.");
                    Console.WriteLine("Wähle eines der Symbole, um deinen Weg zu bestimmen. (schwert/laterne/maske)");
                    string symbolWahl = Console.ReadLine().ToLower();

                    if (symbolWahl == "schwert")
                    {
                        Console.WriteLine("\n🔥 Das Schwert leuchtet auf, und du spürst eine plötzliche Kraft durch deinen Körper strömen.");
                        Console.WriteLine("Die Dunkelheit weicht zurück, und du findest dich in einer alten Kampfarena wieder. Ein Schattenkrieger erscheint!");
                        Console.WriteLine("Du musst kämpfen, um weiterzukommen...\n");
                    }
                    else if (symbolWahl == "laterne")
                    {
                        Console.WriteLine("\n🏮 Die Laterne entzündet sich, und ihr warmes Licht durchdringt die Dunkelheit.");
                        Console.WriteLine("Die Umgebung ändert sich, und du stehst in einer Bibliothek voller alter Schriftrollen. Wissen ist dein Schlüssel zum Weiterkommen.");
                        Console.WriteLine("Du musst ein uraltes Rätsel lösen, um weiterzukommen...\n");
                    }
                    else if (symbolWahl == "maske")
                    {
                        Console.WriteLine("\n🎭 Die Maske schwebt vor dein Gesicht und du fühlst, wie sich deine Sinne schärfen.");
                        Console.WriteLine("Du bist plötzlich unsichtbar und kannst die Schatten ungesehen durchqueren.");
                        Console.WriteLine("Doch Vorsicht! Täuschung kann gefährlich sein, wenn sie entdeckt wird...\n");
                    }
                    else
                    {
                        Console.WriteLine("\n❌ Deine Unentschlossenheit wird bestraft! Die Schatten greifen dich an, und du verlierst das Bewusstsein...");
                        Console.WriteLine("Vielleicht solltest du beim nächsten Mal eine Entscheidung treffen...\n");
                    }
                }
                static void BetreteGeheimeKammer()
                {
                    Console.Clear();
                    Console.WriteLine("\n🔮 Nach bestandener Prüfung öffnet sich eine geheime Tür in der Dunkelheit.");
                    Console.WriteLine("Du betrittst eine alte, mystische Kammer voller leuchtender Runen.");
                    Console.WriteLine("In der Mitte des Raumes schwebt ein uralter Kristall, umgeben von schattigen Silhouetten...");

                    Console.WriteLine("\nEine tiefe Stimme hallt durch den Raum: 'Du hast die Prüfung bestanden, doch bist du bereit für die Wahrheit?'");
                    Console.WriteLine("\nWillst du den Kristall berühren oder die Umgebung erkunden? (berühren/erkunden)");
                    string entscheidung = Console.ReadLine().ToLower();

                    if (entscheidung == "berühren")
                    {
                        Console.WriteLine("\n⚡ Sobald deine Finger den Kristall berühren, durchzuckt dich eine gewaltige Energie!");
                        Console.WriteLine("Visionen alter Zeiten flammen in deinem Geist auf – Bilder von vergessenen Königreichen und gefallenen Helden.");
                        Console.WriteLine("Du fühlst, wie sich deine Kräfte verändern...");
                    }
                    else if (entscheidung == "erkunden")
                    {
                        Console.WriteLine("\n🔍 Du entscheidest dich, den Raum genauer zu untersuchen.");
                        Console.WriteLine("Zwischen den alten Schriftrollen entdeckst du ein verborgenes Geheimnis über die Wächter des Dungeons.");
                        Console.WriteLine("Plötzlich bewegt sich eine der Schattenfiguren auf dich zu...");
                        Console.WriteLine("\nBist du bereit, dich dem Unbekannten zu stellen?");
                    }
                    else
                    {
                        Console.WriteLine("\n❌ Deine Zögerlichkeit kostet dich wertvolle Zeit. Der Raum beginnt zu beben, und die Schatten rücken näher...");
                        Console.WriteLine("Vielleicht war das nicht die beste Wahl...");
                        
                    }
                }
                static void EnthuelleWahrheit()
                {
                    Console.Clear();
                    Console.WriteLine("\n✨ Der Raum beginnt sich zu verändern. Die Schatten weichen zurück, und eine verborgene Tür erscheint.");
                    Console.WriteLine("Eine Stimme erklingt: 'Du hast Mut bewiesen, nun sollst du die Wahrheit erfahren.'");

                    Console.WriteLine("\nMöchtest du die Tür betreten oder weiter in der Kammer suchen? (betreten/suchen)");
                    string entscheidung = Console.ReadLine().ToLower();

                    if (entscheidung == "betreten")
                    {
                        Console.WriteLine("\n🚪 Du betrittst den neuen Raum und findest eine riesige Bibliothek voller verborgener Weisheiten.");
                        Console.WriteLine("Inmitten der Regale liegt ein altes Buch mit einem glänzenden Symbol auf dem Einband...");
                        Console.WriteLine("\nWillst du das Buch öffnen oder nach weiteren Hinweisen suchen? (öffnen/suchen)");
                        string buchWahl = Console.ReadLine().ToLower();

                        if (buchWahl == "öffnen")
                        {
                            Console.WriteLine("\n📖 Als du das Buch öffnest, durchströmt dich eine Welle aus purem Wissen.");
                            Console.WriteLine("Du verstehst nun die wahre Geschichte des Dungeons und deine Rolle darin...");
                            // Hier könnte eine neue Fähigkeit oder Quest starten
                        }
                        else
                        {
                            Console.WriteLine("\n🔍 Du beginnst, die Umgebung weiter zu durchsuchen und findest ein verborgenes Artefakt.");
                            Console.WriteLine("Vielleicht ist es mächtiger als ein bloßes Buch...");
                            // Möglichkeit für ein alternatives Belohnungssystem
                        }
                    }
                    else if (entscheidung == "suchen")
                    {
                        Console.WriteLine("\n🔦 Du bleibst in der Kammer und untersuchst die Wände.");
                        Console.WriteLine("Du findest eine uralte Inschrift, die von einer verborgenen Macht spricht...");
                        Console.WriteLine("Plötzlich beginnt die Kammer zu beben, und eine verborgene Falle wird ausgelöst!");
                        // Hier könnte eine Flucht- oder Kampfsequenz folgen
                    }
                    else
                    {
                        Console.WriteLine("\n❌ Deine Zögerlichkeit kostet dich wertvolle Zeit. Die Schatten verdichten sich erneut...");
                        Console.WriteLine("Bald wirst du keine Möglichkeit mehr haben, die Wahrheit zu erfahren...");
                        // Konsequenzen oder alternative Enden
                    }
                }
                static void FinaleHerausforderung()
                {
                    Console.Clear();
                    Console.WriteLine("\n🔥 Während du die alte Bibliothek durchsuchst, öffnet sich ein geheimer Durchgang im Boden.");
                    Console.WriteLine("Eine dunkle Treppe führt hinab in eine leuchtende Kammer mit einem schimmernden Portal in der Mitte.");
                    Console.WriteLine("Eine unheilvolle Stimme spricht: 'Nur wer bereit ist, sich selbst zu opfern, kann die wahre Macht erlangen.'");

                    Console.WriteLine("\nWillst du durch das Portal schreiten oder nach einem alternativen Weg suchen? (portal/suchen)");
                    string entscheidung = Console.ReadLine().ToLower();

                    if (entscheidung == "portal")
                    {
                        Console.WriteLine("\n🌌 Du trittst durch das Portal und findest dich in einer anderen Dimension wieder.");
                        Console.WriteLine("Vor dir steht eine schattenhafte Gestalt, die genau wie du aussieht... Dein eigenes Spiegelbild.");
                        Console.WriteLine("Der Schatten spricht: 'Nur einer von uns kann existieren. Beweise deine Stärke!'");
                        Console.WriteLine("\nWirst du kämpfen oder versuchen, mit dem Schatten zu verhandeln? (kämpfen/verhandeln)");
                        string kampfEntscheidung = Console.ReadLine().ToLower();

                        if (kampfEntscheidung == "kämpfen")
                        {
                            Console.WriteLine("\n⚔ Ein epischer Kampf beginnt, in dem du gegen dein eigenes Spiegelbild antreten musst!");
                            Console.WriteLine("Du setzt all deine erlernten Fähigkeiten ein und nach einem langen Duell besiegst du den Schatten.");
                            Console.WriteLine("Als der Schatten verschwindet, spürst du eine neue Macht in dir erwachen...");
                            // Hier könnte eine neue Fähigkeit oder eine Transformation folgen
                        }
                        else
                        {
                            Console.WriteLine("\n🗣 Du sprichst mit dem Schatten und erkennst, dass es ein Teil deines inneren Selbst ist.");
                            Console.WriteLine("Statt zu kämpfen, umarmst du den Schatten und integrierst seine Stärke in dich.");
                            Console.WriteLine("Du erwachst mit einem völlig neuen Verständnis deiner selbst und erhältst eine besondere Gabe...");
                            // Hier könnte eine alternative Belohnung oder Endsequenz folgen
                        }
                    }
                    else if (entscheidung == "suchen")
                    {
                        Console.WriteLine("\n🔦 Du suchst weiter in der Kammer und findest eine versteckte Inschrift.");
                        Console.WriteLine("Die Worte enthüllen eine uralte Technik, die das Portal umgehen kann...");
                        Console.WriteLine("Plötzlich beginnt die Kammer zu beben – du musst dich schnell entscheiden!");
                        Console.WriteLine("Willst du das Ritual durchführen oder das Portal betreten? (ritual/portal)");
                        string ritualEntscheidung = Console.ReadLine().ToLower();

                        if (ritualEntscheidung == "ritual")
                        {
                            Console.WriteLine("\n✨ Du rezitierst die alten Worte und das Portal beginnt sich zu verändern.");
                            Console.WriteLine("Anstatt hindurchzugehen, absorbierst du seine Energie und wirst selbst zur Quelle der Macht!");
                            Console.WriteLine("Ein neues Schicksal offenbart sich dir...");
                            // Möglichkeit für eine göttliche Transformation oder ein alternatives Ende
                        }
                        else
                        {
                            Console.WriteLine("\n🌠 Du entscheidest dich doch für das Portal und springst hindurch, bereit für dein ultimatives Schicksal!");
                            Console.WriteLine("Doch was dich auf der anderen Seite erwartet, bleibt ein Mysterium...");
                            // Offenes oder geheimnisvolles Ende
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n❌ Deine Unentschlossenheit kostet dich wertvolle Zeit. Die Kammer beginnt einzustürzen...");
                        Console.WriteLine("Vielleicht war das nicht die beste Wahl...");
                        // Möglichkeit für Konsequenzen oder einen Neustart
                    }
                }
                 static void FinaleEntscheidung()
                {
                    Console.Clear();
                    Console.WriteLine("\n🌌 Du stehst nun am Rand des Universums, die Energie des Portals pulsierend um dich herum.");
                    Console.WriteLine("Eine letzte Stimme spricht: 'Dies ist dein Moment der Wahrheit. Wähle weise.'");

                    Console.WriteLine("\nDrei Wege stehen dir offen: Der Pfad des Lichts ☀, der Pfad der Dunkelheit ☾ oder der Pfad des Gleichgewichts ⚖.");
                    Console.WriteLine("Welchen Weg wählst du? (licht/dunkelheit/gleichgewicht)");
                    string wegWahl = Console.ReadLine().ToLower();

                    if (wegWahl == "licht")
                    {
                        Console.WriteLine("\n☀ Du entscheidest dich für das Licht. Dein Körper beginnt zu leuchten, als du dich in reine Energie verwandelst.");
                        Console.WriteLine("Du steigst in eine höhere Existenzebene auf und wirst zum Wächter der Realität.");
                        Console.WriteLine("\nGlückwunsch! Du hast das ultimative Ende erreicht.");
                    }
                    else if (wegWahl == "dunkelheit")
                    {
                        Console.WriteLine("\n☾ Du gibst dich der Dunkelheit hin. Schatten fließen durch deine Adern, deine Augen werden schwarz.");
                        Console.WriteLine("Du wirst zum Herrscher der Schatten, unaufhaltsam, aber von ewiger Einsamkeit umgeben.");
                        Console.WriteLine("\nEin neuer Zyklus beginnt, und du wirst zur Legende der Dunkelheit.");
                    }
                    else if (wegWahl == "gleichgewicht")
                    {
                        Console.WriteLine("\n⚖ Du wählst den Pfad des Gleichgewichts. Licht und Dunkelheit vereinen sich in dir.");
                        Console.WriteLine("Du wirst zur perfekten Harmonie, ein Wesen jenseits der Zeit und der Regeln des Universums.");
                        Console.WriteLine("\nDu erschaffst eine neue Realität, in der alle Schicksale miteinander verknüpft sind.");
                    }
                    else
                    {
                        Console.WriteLine("\n❌ Deine Unentschlossenheit bringt Chaos. Die Welt um dich herum zerfällt in Nichts...");
                        Console.WriteLine("Vielleicht hättest du mutiger sein sollen.");
                    }

                    Console.WriteLine("\n🎇 Deine Reise ist nun zu Ende. Möchtest du noch einmal von vorne beginnen? (ja/nein)");
                    string restart = Console.ReadLine().ToLower();

                    if (restart == "ja")
                    {
                        Console.WriteLine("\n🔄 Dein Geist kehrt zurück in die Welt des Anfangs...");
                        FinaleEntscheidung();
                    }
                    else
                    {
                        Console.WriteLine("\n👋 Danke, dass du dieses Abenteuer erlebt hast. Bis zum nächsten Mal!");
                    }
                }
            }
        }
    }
}

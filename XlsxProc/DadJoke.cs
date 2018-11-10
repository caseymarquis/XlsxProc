using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XlsxProc {
    class DadJoke {
        public static string Get() {
            var formatted = Data.Split('\n').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => x.Trim()).ToList();
            return formatted[new Random().Next(formatted.Count)];
        }

        public static readonly string Data = @"
I'll tell you what often gets over looked... garden fences.
 Why do birds fly south for the winter? Because it's too far to walk.
 What is a centipedes's favorite Beatle song?  I want to hold your hand, hand, hand, hand...
 My first time using an elevator was an uplifting experience. The second time let me down.
 To be Frank, I'd have to change my name.
 Slept like a log last night … woke up in the fireplace.
 Why does a Moon-rock taste better than an Earth-rock? Because it's a little meteor.
 I thought my wife was joking when she said she'd leave me if I didn't stop singing ""I'm A Believer""... Then I saw her face.
 What do you call two barracuda fish? A Pairacuda!
 Why is Peter Pan always flying? Because he Neverlands.
 What do you do on a remote island? Try and find the TV island it belongs to.
 Did you know that protons have mass? I didn't even know they were catholic.
 Dad I’m hungry’ … ‘Hi hungry I’m dad
 I was fired from the keyboard factory yesterday.I wasn't putting in enough shifts.
 Whoever invented the knock-knock joke should get a no bell prize.
 Do I enjoy making courthouse puns? Guilty
 Why couldn't the kid see the pirate movie? Because it was rated arrr!
 Man, I really love my furniture...me and my recliner go way back.
 What did the traffic light say to the car as it passed? ""Don't look I'm changing!""
Conjunctivitis.com – now that’s a site for sore eyes.
 How many South Americans does it take to change a lightbulb? A Brazilian
 I don't trust stairs. They're always up to something.
 A police officer caught two kids playing with a firework and a car battery. He charged one and let the other one off.
 I went to a Foo Fighters Concert once... It was Everlong...
 Some people eat light bulbs.They say it's a nice light snack.
 I cut my finger chopping cheese, but I think that I may have grater problems.
 What do you get hanging from Apple trees? Sore arms.
 Last night me and my girlfriend watched three DVDs back to back. Luckily I was the one facing the TV.
 I got a reversible jacket for Christmas, I can't wait to see how it turns out.
 My pet mouse 'Elvis' died last night.He was caught in a trap..
 Never take advice from electrons.They are always negative.
 What did the beaver say to the tree? It's been nice gnawing you.
 What did the late tomato say to the early tomato? I’ll ketch up
 I have kleptomania, but when it gets bad, I take something for it.
 I used to be addicted to soap, but I'm clean now.
 I made a belt out of watches once...It was a waist of time.
 This furniture store keeps emailing me, all I wanted was one night stand!
 How do you find Will Smith in the snow?  Look for fresh prints.
 I just read a book about Stockholm syndrome. It was pretty bad at first, but by the end I liked it.
My boss told me to attach two pieces of wood together...I totally nailed it!
 Recent survey revealed 6 out of 7 dwarf's aren't happy.
 What do you call corn that joins the army? Kernel.
 ‘Put the cat out’ … ‘I didn’t realize it was on fire
 Two muffins were sitting in an oven, and the first looks over to the second, and says, “man, it’s really hot in here”. The second looks over at the first with a surprised look, and answers, “WHOA, a talking muffin!”
 What's the difference between a guitar and a fish? You can tune a guitar but you can't ""tuna"" fish!
 Did you hear that the police have a warrant out on a midget psychic ripping people off? It reads “Small medium at large.”
Why do trees seem suspicious on sunny days? Dunno, they're just a bit shady.
 If at first you don't succeed, sky diving is not for you!
 A book just fell on my head.I only have my shelf to blame.
 What did the dog say to the two trees? Bark bark.
 Why can't your nose be 12 inches long? Because then it'd be a foot!
 Have you ever heard of a music group called Cellophane? They mostly wrap.
 What did the mountain climber name his son? Cliff.
 Whiteboards...are remarkable.
 What’s Forest Gump’s Facebook password? 1forest1
 Whenever the cashier at the grocery store asks my dad if he would like the milk in a bag he replies, ‘No, just leave it in the carton!’
 I used to be addicted to the hokey pokey, but I turned myself around.
 How many tickles does it take to tickle an octopus? Ten-tickles!
Just read a few facts about frogs.They were ribbiting.
 Two satellites decided to get married. The wedding wasn't much, but the reception was incredible.
 They tried to make a diamond shaped like a duck. It quacked under the pressure.
 Where’s the bin? Dad: I haven’t been anywhere!
 Why do bears have hairy coats? Fur protection.
 What do you get when you cross a bee and a sheep? A bah-humbug.
 What did one snowman say to the other snow man? Do you smell carrot?
 Why do bees hum? Because they don't know the words.
 What do you call a troublesome Canadian high schooler? A poutine.
 A magician was driving down the street and then he turned into a driveway.
 Don't trust atoms. They make up everything.
 If you walk into a forest and cut down a tree, but the tree doesn't understand why you cut it down, do you think it's stumped?
 Where do bees go to the bathroom? The BP station.
 What do you call a bee that lives in America? A USB.
 I was wondering why the frisbee was getting bigger, then it hit me.
 What's the difference between a hippo and a zippo? One is really heavy, the other is a little lighter.
 I couldn't figure out how the seat belt worked. Then it just clicked.
 What do you call a dad that has fallen through the ice? A Popsicle.
 Two parrots are sitting on a perch.One turns to the other and asks, ""do you smell fish?""
 Bad at golf? Join the club.
Can a kangaroo jump higher than the Empire State Building? Of course. The Empire State Building can't jump.
 What do you give a sick lemon? Lemonaid.
 I just got fired from a florist, apparently I took too many leaves.
 Why don’t skeletons ever go trick or treating? Because they have nobody to go with.
 What does a female snake use for support? A co-Bra!
 ""Dad, I'm cold.""
""Go stand in the corner, I hear it's 90 degrees.""
 Child: Dad, make me a sandwich. Dad: Poof! You're a sandwich.
 What kind of bagel can fly? A plain bagel.
 How many apples grow on a tree? All of them!
 What do you call a careful wolf? Aware wolf.
 I was just looking at my ceiling.Not sure if it’s the best ceiling in the world, but it’s definitely up there.
 Why do valley girls hang out in odd numbered groups? Because they can't even.
 “My Dog has no nose.” “How does he smell?” “Awful”
 What do you call a cow with no legs? Ground beef.
 Why did the half blind man fall in the well? Because he couldn't see that well!
 As I suspected, someone has been adding soil to my garden. The plot thickens.
 It’s hard to explain puns to kleptomaniacs, because they take everything literally.
 It's difficult to say what my wife does, she sells sea shells by the sea shore.
 what do you call a dog that can do magic tricks? a labracadabrador
 Atheism is a non-prophet organisation.
What do you call a monkey in a mine field? A babooooom!
 I cut my finger cutting cheese. I know it may be a cheesy story but I feel grate now.
 How do you steal a coat? You jacket.
 I’m reading a book on the history of glue – can’t put it down.
 Want to hear a joke about construction? Nah, I'm still working on it.
 Just watched a documentary about beavers… It was the best damn program I’ve ever seen.
 Why do choirs keep buckets handy? So they can carry their tune
 Did you hear about the kidnapping at school? It's ok, he woke up.
 You can't run through a camp site. You can only ran, because it's past tents.
 They're making a movie about clocks. It's about time
 Archaeology really is a career in ruins.
 I was going to get a brain transplant, but I changed my mind
 Why can't you use ""Beef stew"" as a password? Because it's not stroganoff.
 Why couldn't the lifeguard save the hippie? He was too far out, man.
 Why did the girl smear peanut butter on the road? To go with the traffic jam.
 The rotation of earth really makes my day.
 How much does a hipster weigh? An instagram.
 A woman is on trial for beating her husband to death with his guitar collection.Judge says, ‘First offender?’ She says, ‘No, first a Gibson! Then a Fender!’
 I saw an ad in a shop window, ""Television for sale, $1, volume stuck on full"", I thought, ""I can't turn that down"".
 What kind of dog lives in a particle accelerator? A Fermilabrador Retriever.
What's blue and not very heavy?  Light blue.
 I was so proud when I finished the puzzle in six months, when on the side it said three to four years.
 Where did you learn to make ice cream? Sunday school.
 Where does Napoleon keep his armies? In his sleevies.
 Leather is great for sneaking around because it's made of hide.
 People are making apocalypse jokes like there’s no tomorrow.
 What is the tallest building in the world? The library – it’s got the most stories!
 What kind of magic do cows believe in? MOODOO.
 I just broke my guitar.It's okay, I won't fret
 How many kids with ADD does it take to change a lightbulb? Let's go ride bikes!
 What do you call a cow with two legs? Lean beef.
 Who is the coolest Doctor in the hospital? The hip Doctor!
 Why was ten scared of seven? Because seven ate nine.
 What do you get when you cross a rabbit with a water hose? Hare spray.
 I applied to be a doorman but didn't get the job due to lack of experience. That surprised me, I thought it was an entry level position.
 I knew a guy who collected candy canes, they were all in mint condition
 Why does a chicken coop only have two doors? Because if it had four doors it would be a chicken sedan.
 ""I'll call you later."" Don't call me later, call me Dad.
 Breaking news! Energizer Bunny arrested – charged with battery.
 A red and a blue ship have just collided in the Caribbean. Apparently the survivors are marooned.
“Doctor, I’ve broken my arm in several places” Doctor “Well don’t go to those places.”
 What’s the difference between an African elephant and an Indian elephant? About 5000 miles.
 What did the Zen Buddist say to the hotdog vendor? Make me one with everything.
 Did you hear the one about the guy with the broken hearing aid? Neither did he.
 What did the Red light say to the Green light? Don't look at me I'm changing!
 What did the ocean say to the beach? Thanks for all the sediment.
I've just written a song about a tortilla. Well, it is more of a rap really.
 Can February march? No, but April may.
 So a duck walks into a pharmacy and says “Give me some chap-stick… and put it on my bill”
 Egyptians claimed to invent the guitar, but they were such lyres.
 Toasters were the first form of pop-up notifications.
 What do you call a crowd of chess players bragging about their wins in a hotel lobby? Chess nuts boasting in an open foyer.
 Which side of the chicken has more feathers? The outside.
 Remember, the best angle to approach a problem from is the ""try"" angle.
 Why are fish easy to weigh? Because they have their own scales.
 What did the scarf say to the hat? You go on ahead, I am going to hang around a bit longer.
 Did you hear about the scientist who was lab partners with a pot of boiling water? He had a very esteemed colleague.
 This morning I was wondering where the sun was, but then it dawned on me.
 Writing with a broken pencil is pointless.
What do you call a fly without wings? A walk.
 Velcro… What a rip-off.
 Have you heard the rumor going around about butter? Never mind, I shouldn't spread it.
 What happens to a frog's car when it breaks down? It gets toad.
 I fear for the calendar, it’s days are numbered.
 I'm glad I know sign language, it's pretty handy.
 The other day, my wife asked me to pass her lipstick but I accidentally passed her a glue stick. She still isn't talking to me.
 What do you get when you cross a chicken with a skunk? A fowl smell!
 How many hipsters does it take to change a lightbulb? Oh, it's a really obscure number. You've probably never heard of it.
 Our wedding was so beautiful, even the cake was in tiers.
 Why is the new Kindle screen textured to look like paper? So you feel write at home.
 When my wife told me to stop impersonating a flamingo, I had to put my foot down.
 What’s the advantage of living in Switzerland? Well, the flag is a big plus.
 Why did the cookie cry? It was feeling crumby.
 Nurse: Doctor, there's a patient that says he's invisible. Doctor: Well, tell him I can't see him right now!
 What was a more important invention than the first telephone? The second one.
 What do you get when you cross a snowman with a vampire? Frostbite.
 Did you know crocodiles could grow up to 15 feet? But most just have 4.
 Why did the fireman wear red, white, and blue suspenders? To hold his pants up.
 What do you call someone with no nose? Nobody knows.
What do you call a girl between two posts? Annette.
 What do you call a fat psychic? A four-chin teller.
 I used to be a banker, but I lost interest.
 Why can't a bicycle stand on its own? It's two-tired.
 What does a pirate pay for his corn? A buccaneer!
 Astronomers got tired watching the moon go around the earth for 24 hours.They decided to call it a day.
 My dog used to chase people on a bike a lot.It got so bad I had to take his bike away.
 I ate a clock yesterday.It was so time consuming.
 Two dyslexics walk into a bra.
 Milk is also the fastest liquid on earth – its pasteurized before you even see it
 Is the pool safe for diving? It deep ends.
 Why do scuba divers fall backwards into the water? Because if they fell forwards they’d still be in the boat.
 My wife told me to rub the herbs on the meat for better flavor. That's sage advice.
 A man was caught stealing in a supermarket today while balanced on the shoulders of a couple of vampires.He was charged with shoplifting on two counts. 
 Ben & Jerry's really need to improve their operation. The only way to get there is down a rocky road.
 What time did the man go to the dentist? Tooth hurt-y.
 Did you hear about the cheese factory that exploded in France? There was nothing left but de Brie.
 What is this movie about? It is about 2 hours long.
 Why are pirates called pirates? Because they arrr!
 Where does Fonzie like to go for lunch? Chick-Fil-Eyyyyyyyy.
";
    }
}

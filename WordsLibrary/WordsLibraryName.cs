using System.Collections.Generic;

namespace WordsLibraryName
{
    public class WordsLibrary
    {
        public List<string> words { get; set; }
        public WordsLibrary()
        {
            words = new List<string>()
            {
                // A
                 "Apple", "Art", "Animal", "Airplane", "Abstract", "Adventure", "Academy", "Antelope", "Astronomy",
            "Apartment", "Alphabet", "Argument", "Authority", "Anxiety", "Approach", "Actor", "Attitude",
            "Ambition", "Aromatic", "Aisle", "Absurd", "Acoustic", "Affair", "Arsenal", "Advisor",
            "Allegory", "Agility", "Assemble", "Algebra", "Ancestor", "Avocado", "Associate", "Abundant",
            "Arrangement", "Archaeology", "Appliance", "Accessory", "Amplify", "Agenda", "Advertisement",
            "Aerial", "Archive", "Amusement", "Analyze", "Absence", "Adaptation", "Artisan", "Admire",
            "Adrenaline", "Authentic", "Auction", "Asteroid", "Apathy", "Asylum", "Attendance", "Advisory",
            "Aroma", "Audition", "Aquarium", "Aspire", "Ailment", "Accordance", "Advocate", "Adept", 
            
            // B
            "Baby", "Ball", "Book", "Bird", "Basket", "Banana", "Bicycle", "Bridge", "Butterfly", "Blue",
            "Box", "Brush", "Bean", "Bat", "Balloon", "Bee", "Branch", "Bag", "Board", "Bottle",
            "Brick", "Bus", "Bread", "Bowl", "Bell", "Bench", "Bolt", "Bubble", "Band", "Bone",
            "Bay", "Badge", "Bark", "Berry", "Bumper", "Biscuit", "Bank", "Blanket", "Boat", "Bracelet",
            "Bead", "Buckle", "Barrel", "Bridle", "Beadle", "Barn", "Bangle", "Brazier", "Balsam", "Bamboo",
            "Bridal", "Baste", "Balmy", "Bobby", "Bribe", "Brewer", "Bray", "Braid", "Botch", "Bungle", 
            
            // C
            "Cat", "Car", "Computer", "Cake", "Chocolate", "Coffee", "City", "Camera", "Candle", "Chair",
            "Cloud", "Clothes", "Couch", "Coin", "Cherry", "Chicken", "Clock", "Cup", "Cookie", "Cheese",
            "Cellphone", "Calendar", "Customer", "Canvas", "Clown", "Cotton", "Chalk", "Cinema", "Cabbage", "Carpenter",
            "Cartoon", "Cucumber", "Castle", "Cave", "Curtain", "Coconut", "Carnival", "Comet", "Collar", "Coat",
            "Chef", "Circus", "Chisel", "Champion", "Creek", "Cabin", "Coral", "Cactus", "Cherry", "Cafeteria", 
            
            // D
            "Dog", "Dance", "Dolphin", "Dream", "Diamond", "Dinosaur", "Dress", "Doctor", "Door", "Duck",
            "Dragon", "Desk", "Dictionary", "Daisy", "Disk", "Dust", "Drum", "Diver", "Diploma", "Driver",
            "Deck", "Dinner", "Donkey", "Drama", "Dove", "Doughnut", "Dentist", "Dollar", "Desert", "Data",
            "Drift", "Denim", "Diplomat", "Dungeon", "Dagger", "Dump", "Dew", "Daffodil", "Doodle", "Dart",
            "Dawn", "Doubt", "Diary", "Drizzle", "Dispatch", "Drape", "Dune", "Dinnerware", "Donor", "Debate", 
            
            // E
            "Elephant", "Eagle", "Engine", "Egg", "Earth", "Echo", "Elegant", "Emperor", "Envelope", "Elevator",
            "Eclipse", "Elder", "Energy", "Emerge", "Embark", "Empathy", "Enjoy", "Escape", "Epic", "Essay",
            "Espresso", "Evergreen", "Exotic", "Expand", "Expert", "Express", "Evoke", "Eureka", "Execute", "Exhibit",
            "Explore", "Exquisite", "Extinct", "Extra", "Extract", "Eyeball", "Elastic", "Elaborate", "Elation", "Elegant",
            "Electron", "Ellipse", "Encounter", "Endurance", "Enthusiasm", "Envelop", "Essence", "Establish", "Ethereal", "Evolve", 
            
            // F
            "Fox", "Fire", "Fish", "Flower", "Flag", "Forest", "Fruit", "Feather", "Family", "Fan",
            "Fence", "Fountain", "Flame", "Fog", "Field", "Feast", "Ferry", "Fiddle", "Fragrance", "Fiber",
            "Fossil", "Fumble", "Futuristic", "Fairy", "Falcon", "Flicker", "Frost", "Fame", "Flick", "Fracture",
            "Foster", "Frequent", "Facade", "Furnace", "Fragile", "Fruitful", "Foresee", "Forensic", "Formulate", "Fleeting",

                        // G
            "Goat", "Garden", "Guitar", "Game", "Grass", "Globe", "Grace", "Gold", "Giraffe", "Glitter",
            "Ghost", "Gazelle", "Ginger", "Gadget", "Gallery", "Gym", "Garlic", "Gulf", "Glimpse", "Glimmer",
            "Grain", "Glee", "Growth", "Glacier", "Gorge", "Gentle", "Gesture", "Gala", "Globule", "Graffiti",
            "Gourmet", "Glaze", "Gravel", "Gizmo", "Grave", "Glisten", "Griddle", "Guard", "Gondola", "Griddle",
            "Grasshopper", "Gloss", "Glow", "Grill", "Gown", "Guilt", "Gent", "Gargle", "Gnash", "Gargantuan",
            
            // H
            "Horse", "House", "Heart", "Hope", "Honey", "Harp", "Hill", "Hammer", "Harmony", "Hug",
            "Horizon", "Hail", "Halo", "Hatch", "Hike", "Humor", "Hurdle", "Habitat", "Hush", "Hazard",
            "Hybrid", "Hymn", "Hole", "Hurdle", "Heirloom", "Hollow", "Harness", "Harbor", "Hunk", "Holler",
            "Hitch", "Hurl", "Hose", "Hustle", "Hunk", "Hurl", "Honor", "Herald", "Hunk", "Hurtle",
            "Huddle", "Hurler", "Hose", "Hurtle", "Hut", "Hydrant", "Hustle", "Hose", "Humor", "Hydrant",
            
            // I
            "Ice", "Idea", "Ink", "Iron", "Igloo", "Ivy", "Island", "Icicle", "Iris", "Illusion",
            "Infinity", "Impulse", "Illumination", "Intrigue", "Insight", "Incense", "Identity", "Invention", "Ivory", "Impression",
            "Infrastructure", "Incident", "Intricate", "Inhale", "Inventor", "Invoice", "Influx", "Intent", "Integrity", "Interface",
            "Inheritance", "Instinct", "Ivory", "Invoke", "Insert", "Initial", "Infinite", "Inspiration", "Intuition", "Irrigation",
            "Invoke", "Insight", "Infrastructure", "Inquisitive", "Ivory", "Insight", "Iota", "Irony", "Intrigue", "Incite",
            
            // J
            "Jacket", "Jungle", "Jewel", "Jet", "Journey", "Jam", "Jigsaw", "Jockey", "Journal", "Jolt",
            "Jackal", "Jingle", "Jazz", "Jinx", "Jeans", "Joust", "Juror", "Junction", "Jade", "Journey",
            "Jolt", "Jigsaw", "Jewelry", "Jet", "Journey", "Jamboree", "Jumble", "Juggler", "Juice", "Joy",
            "Jute", "Juxtapose", "Jargon", "Jester", "Judge", "Jab", "Jewel", "Jockey", "Joust", "Jiffy",
            "Jut", "Jump", "Jinx", "Juggernaut", "Jubilee", "Jester", "Juxtaposition", "Jabber", "Jive", "Jumbo",
            
            // K
            "Kite", "Key", "King", "Koala", "Kitten", "Kaleidoscope", "Knee", "Knock", "Kernel", "Karma",
            "Knight", "Knot", "Kid", "Kiosk", "Kilogram", "Kettle", "Keyboard", "Kangaroo", "Kale", "Kiosk",
            "Kelp", "Kin", "Kiss", "Kindergarten", "Kitten", "Kneel", "Kaleidoscopic", "Kudos", "Kilt", "Kernel",
            "Karma", "Knockout", "Kiosk", "Keg", "Kettle", "Kitten", "Kick", "Kaleidoscope", "Knack", "Keen",
            "Kiosk", "Kiln", "Kiosk", "Kitten", "Kaleidoscope", "Kilogram", "Kowtow", "Knee", "Kiln", "Knock",
            
            // L
            "Lion", "Lamp", "Lemon", "Lake", "Lizard", "Lily", "Ladder", "Library", "Leaf", "Laptop",
            "Lobster", "Lantern", "Lunch", "Lounge", "Lava", "Lobster", "License", "Lantern", "Lullaby", "Leash",
            "Lavender", "Land", "Lettuce", "Lighthouse", "Leg", "Lilac", "Lag", "Lap", "Lagoon", "Ladle",
            "Leopard", "Liver", "Lull", "Lure", "List", "Lever", "Level", "Launch", "Latch", "Link",
            "Lumber", "Letter", "Laugh", "Lentil", "Lens", "Loaf", "Leafy", "Labyrinth", "Leather", "Loom",

             // M
            "Monkey", "Moon", "Milk", "Mountain", "Magnet", "Mango", "Music", "Machine", "Map", "Movie",
            "Mansion", "Moss", "Mud", "Mitten", "Mars", "Maze", "Moth", "Mug", "Magnet", "Man",
            "Mural", "Mermaid", "Mushroom", "Mist", "Mud", "Meadow", "Mint", "Milestone", "Meteor", "Monsoon",
            "Mansion", "Muffin", "Mortar", "Moth", "Monarch", "Magenta", "Mystic", "Magnet", "Melody", "Muffler",
            "Mud", "Meander", "Meadow", "Mosaic", "Molar", "Mentor", "Magnet", "Marble", "Mortgage", "Magnet",

            // N
            "Nest", "Night", "Noodle", "Notebook", "Nestle", "Nut", "Nectar", "Ninja", "Navy", "Nectarine",
            "Nun", "Nectar", "Nebula", "Nurse", "Necklace", "Nutrition", "Novel", "Nylon", "Nook", "Noodle",
            "Narrator", "Nudge", "Nomad", "Neon", "Nutshell", "Nestle", "Napkin", "Nectar", "Nest", "Nourish",
            "Nuclear", "Nestle", "Nudge", "Nanny", "Nap", "Nymph", "Nudge", "Nest", "Niche", "Nudge",
            "Napkin", "Nest", "Nanny", "Nook", "Nudge", "Neon", "Nest", "Nudge", "Niche", "Noodle",

            // O
            "Owl", "Ocean", "Orange", "Oxygen", "Orchid", "Oar", "Oasis", "Opera", "Olive", "Opal",
            "Oyster", "Octopus", "Office", "Onion", "Oat", "Orchestra", "Ornament", "Outlet", "Oyster", "Oar",
            "Obsidian", "Oregano", "Outfit", "Oath", "Oak", "Orbit", "Orator", "Orphan", "Outlook", "Ornate",
            "Origin", "Opinion", "Orchestra", "Oasis", "Overlook", "Outreach", "Observe", "Opulent", "Occasion", "Odyssey",
            "Oregano", "Oar", "Oath", "Olive", "Orbit", "Oasis", "Opal", "Oyster", "Outlet", "Outlook",

            // P
            "Penguin", "Piano", "Pear", "Park", "Pineapple", "Paint", "Parrot", "Pillow", "Pizza", "Pencil",
            "Pumpkin", "Penguin", "Puzzle", "Pearl", "Pond", "Palette", "Peach", "Palace", "Parade", "Paddle",
            "Pine", "Planet", "Peak", "Pilot", "Pluto", "Petal", "Pavement", "Passion", "Puppet", "Pyramid",
            "Polar", "Pond", "Pavilion", "Pollen", "Prism", "Pickle", "Palm", "Pond", "Porch", "Petal",
            "Puddle", "Perfume", "Pulp", "Pantry", "Platinum", "Pillar", "Pony", "Pond", "Polar", "Pond",

            // Q
            "Queen", "Quest", "Quilt", "Quartz", "Quail", "Quarter", "Quarry", "Quiz", "Quiver", "Queue",
            "Quack", "Quilt", "Quaint", "Quasar", "Quack", "Quarry", "Quick", "Quench", "Quail", "Quota",
            "Quartz", "Quip", "Quill", "Quorum", "Quake", "Quirk", "Quit", "Quartz", "Quench", "Quota",
            "Quiver", "Quail", "Quest", "Quake", "Quilt", "Quarry", "Quill", "Quack", "Quiz", "Quench",
            "Quota", "Quirk", "Quail", "Quake", "Quiz", "Quartz", "Quota", "Quack", "Quench", "Quirk",

            // R
            "Rabbit", "Rainbow", "Rose", "River", "Rocket", "Ring", "Raccoon", "Robot", "Rust", "Ruby",
            "Rhino", "Rug", "Reindeer", "Rope", "Rustic", "Raven", "Riddle", "Raft", "Rhythm", "Radiant",
            "Ranch", "Rogue", "Ripple", "Rain", "Rustle", "Reef", "Rustic", "Rug", "Recess", "Rust",
            "Rubber", "Rug", "Ravage", "Rust", "Rock", "Razor", "Ruin", "Rush", "Rust", "Raven",
            "Rhythm", "Rose", "Road", "Rustic", "Rogue", "Ruby", "Racket", "Rustle", "Rug", "Recess",

            // S
            "Star", "Sun", "Sky", "Snow", "Ship", "Sail", "Sand", "Stone", "Snake", "Squirrel",
            "Spoon", "Sugar", "Surf", "Shark", "Song", "Shadow", "Shell", "Smile", "Spring", "Starfish",
            "Storm", "Serenade", "Silk", "Swan", "Sword", "Statue", "Science", "Spark", "Sphinx", "Stallion",
            "Sailor", "Satchel", "Spectacle", "Slipper", "Sandal", "Sorcerer", "Stroll", "Sunset", "Safari", "Stardust",
            "Sage", "Sundown", "Swoop", "Sip", "Sorbet", "Savanna", "Sculpture", "Shuttle", "Saddle", "Saucer",

            // T
            "Tree", "Tiger", "Table", "Television", "Tennis", "Tea", "Tower", "Turtle", "Trophy", "Thunder",
            "Tornado", "Tent", "Truck", "Torch", "Tide", "Tunnel", "Tissue", "Top", "Tattoo", "Temple",
            "Track", "Trail", "Turbine", "Tundra", "Tickle", "Throne", "Thorn", "Thermostat", "Tapestry", "Tranquil",
            "Tangerine", "Tunnel", "Twilight", "Twine", "Tender", "Thimble", "Timber", "Terrain", "Taffy", "Traverse",
            "Triumph", "Torrent", "Thicket", "Tack", "Tack", "Trellis", "Torch", "Thyme", "Tannin", "Thistle",

            // U
            "Unicorn", "Umbrella", "Umbilical", "Urchin", "Utensil", "Union", "Unity", "Uplift", "Upgrade", "Urgent",
            "Usher", "Upland", "Umpire", "Upstart", "Underdog", "Utmost", "Ultra", "Uproar", "Uptown", "Unison",
            "Underline", "Utter", "Unravel", "Uniform", "Urn", "Ultimate", "Uplink", "Upbeat", "Uppercut", "Umber",
            "Unwind", "Unleash", "Utopia", "Useful", "User", "Utility", "Underpin", "Upturn", "Urge", "Unveil",
            "Union", "Unity", "Uphold", "Usher", "Unwrap", "Umami", "Utensil", "Uranium", "Unrest", "Uncover",

            // V
            "Violet", "Volcano", "Vase", "Vine", "Vest", "Valley", "Velvet", "Venus", "Vacuum", "Village",
            "Voyage", "Vampire", "Vista", "Veil", "Vineyard", "Vegetable", "Vandal", "Victory", "Vanilla", "Verse",
            "Vortex", "Vibration", "Vault", "Veneer", "Vigilant", "Virtue", "Vandalism", "Voucher", "Vibrate", "Vibrant",
            "Verify", "Versatile", "Vivid", "Vengeance", "Vein", "Venture", "Vortex", "Veranda", "Villain", "Vital",
            "Vagabond", "Vice", "Vessel", "Verdict", "Vigorous", "Vulnerable", "Valiant", "Vandalize", "Vagary", "Vex",

            // W
            "Wave", "Wind", "Water", "Whale", "Wheel", "Wing", "Winter", "Wander", "Wizard", "Wish",
            "Whisper", "Wiggle", "Weave", "Wreath", "Wagon", "Waddle", "Weasel", "Whisk", "Warp", "Waffle",
            "Waddle", "Wraith", "Wrist", "Wig", "Wisdom", "Wool", "Waffle", "Web", "Wilt", "Wrangle",
            "Wanderlust", "Whimsical", "Wigwam", "Wrench", "Wavy", "Wistful", "Waddle", "Wilt", "Whittle", "Wiggle",
            "Wobble", "Wealth", "Wanderer", "Win", "Wing", "Wistful", "Waddle", "Wilt", "Woo", "Wavy",

            // X
            "Xylophone", "X-ray", "Xerox", "Xenon", "Xenophobe", "Xanadu", "Xylograph", "Xylitol", "Xenophile", "Xebec",
            "Xenolith", "Xylophonist", "Xenophobe", "Xerox", "Xylem", "Xyster", "Xyst", "Xanthous", "Xenogamy", "Xiphoid",
            "Xanthein", "Xeriscape", "Xenogenesis", "Xyston", "Xenomorphic", "Xenon", "Xerox", "Xanthan", "Xylol", "Xyster",
            "Xerography", "Xenophobe", "Xyst", "Xylem", "Xerophyte", "Xenophile", "Xerox", "Xyster", "Xyst", "Xanadu",
            "Xylograph", "Xanthous", "Xenogamy", "Xiphoid", "Xenolith", "Xyston", "Xyst", "Xanthein", "Xenogenesis", "Xenomorphic",

            // Y
            "Yacht", "Yoga", "Yak", "Yolk", "Yawn", "Yard", "Yoga", "Yule", "Yo-yo", "Yoga",
            "Yelp", "Yam", "Yonder", "Yacht", "Yoga", "Yarn", "Yawn", "Yellow", "Yoga", "Yogi",
            "Yodel", "Yacht", "Yoga", "Yoke", "Yelp", "Yam", "Yonder", "Yield", "Yoga", "Yolk",
            "Yoga", "Yodel", "Yonder", "Yoga", "Yoke", "Yelp", "Yam", "Yawn", "Yellow", "Yoga",
            "Yoga", "Yogi", "Yard", "Yoga", "Yarn", "Yoga", "Yoga", "Yodel", "Yonder", "Yield",

            // Z
            "Zebra", "Zoo", "Zen", "Zinc", "Zipper", "Zest", "Zombie", "Zodiac", "Zephyr", "Zoom",
            "Zone", "Zigzag", "Zest", "Zebra", "Zenith", "Zap", "Zucchini", "Zeal", "Zoo", "Zero",
            "Zillion", "Zephyr", "Zodiac", "Zigzag", "Zest", "Zebra", "Zen", "Zoom", "Zombie", "Zone",
            "Zeppelin", "Zestful", "Zip", "Zenith", "Zoo", "Zilch", "Zephyr", "Zest", "Zebra", "Zen",
            "Zodiac", "Zoom", "Zone", "Zigzag", "Zest", "Zephyr", "Zombie", "Zenith", "Zoo", "Zap"
            };

        }
        public void AddNewWord(string newWord)
        {
            this.words.Add(newWord);
        }
    }
}

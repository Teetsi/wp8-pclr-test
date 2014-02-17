using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PsychoTest.Resources;

namespace PsychoTest.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<QuestionModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<QuestionModel> Items { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            this.Items.Add(new QuestionModel()
            {
                ID = "1",
                Title = "Glib and Superficial Charm",
                Description = "The tendency to be smooth, engaging, charming, slick, and verbally facile.\nPsychopathic charm is not in the least shy, self-conscious, or afraid to say anything."
            });

            this.Items.Add(new QuestionModel()
            {
                ID = "2",
                Title = "Grandiose Self-Worth",
                Description = "A grossly inflated view of one's abilities and self-worth, self-assured, opinionated, cocky, a braggart.\n\nPsychopaths are arrogant people who believe they are superior human beings."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "3",
                Title = "Need for Stimulation or Proneness to Boredom",
                Description = "An excessive need for novel, thrilling, and exciting stimulation; taking chances and doing things that are risky."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "4",
                Title = "Pathological Lying",
                Description = "Can be moderate or high; in moderate form, they will be shrewd, crafty, cunning, sly, and clever; in extreme form, they will be deceptive, deceitful, underhanded, unscrupulous, manipulative, and dishonest."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "5",
                Title = "Conning and Manipulativeness",
                Description = "The use of deceit and deception to cheat, con, or defraud others for personal gain."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "6",
                Title = "Lack of Guilt",
                Description = "A lack of feelings or concern for the losses, pain, and suffering of victims; a tendency to be unconcerned, dispassionate, coldhearted, and unempathic.\nThis item is usually demonstrated by a disdain for one's victims."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "7",
                Title = "Shallow Affect",
                Description = "Emotional poverty or a limited range or depth of feelings; interpersonal coldness in spite of signs of open gregariousness."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "8",
                Title = "Callousness and Lack of Empathy",
                Description = "A lack of feelings toward people in general; cold, contemptuous, inconsiderate, and tactless."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "9",
                Title = "Parasitic Lifestyle",
                Description = "An intentional, manipulative, selfish, and exploitative financial dependence on others as reflected in a lack of motivation, low self-discipline, and inability to begin or complete responsibilities."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "10",
                Title = "Poor Behavioral Controls",
                Description = "Expressions of irritability, annoyance, impatience, threats, aggression, and verbal abuse; inadequate control of anger and temper; acting hastily."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "11",
                Title = "Promiscuous Sexual Behavior",
                Description = "A variety of brief, superficial relations, numerous affairs, and an indiscriminate selection of sexual partners;the maintenance of several relationships at the same time."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "12",
                Title = "Early Behavior Problems",
                Description = "A variety of behaviors prior to age 13, including lying, theft, cheating, vandalism, bullying, sexual activity, fire-setting, glue-sniffing, alcohol use, and running away from home."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "13",
                Title = "Lack of Realistic, Long-Term Goals",
                Description = "An inability or persistent failure to develop and execute long-term plans and goals; a nomadic existence, aimless, lacking direction in life."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "14",
                Title = "Impulsivity",
                Description = "The occurrence of behaviors that are unpremeditated and lack reflection or planning; inability to resist temptation, frustrations, and urges; a lack of deliberation without considering the consequences; foolhardy, rash, unpredictable, erratic, and reckless."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "15",
                Title = "Irresponsibility",
                Description = "Repeated failure to fulfill or honor obligations and commitments; such as not paying bills, defaulting on loans, performing sloppy work, being absent or late to work, failing to honor contractual agreements."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "16",
                Title = "Failure to Accept Responsibility",
                Description = "A failure to accept responsibility for one's actions reflected in low conscientiousness, an absence of dutifulness, antagonistic manipulation, denial of responsibility, and an effort to manipulate others through this denial."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "17",
                Title = "Many Short-Term Marital Relationships",
                Description = "A lack of commitment to a long-term relationship reflected in inconsistent, undependable, and unreliable commitments in life, including marital."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "18",
                Title = "Juvenile Delinquency",
                Description = "Behavior problems between the ages of 13-18; mostly behaviors that are crimes or clearly involve aspects of antagonism, exploitation, aggression, manipulation, or a callous, ruthless tough-mindedness."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "19",
                Title = "Revocation of Condition Release",
                Description = "A revocation of probation or other conditional release due to technical violations, such as carelessness, low deliberation, or failing to appear."
            });
            this.Items.Add(new QuestionModel()
            {
                ID = "20",
                Title = "Criminal Versatility",
                Description = "A diversity of types of criminal offenses, regardless if the person has been arrested or convicted for them; taking great pride at getting away with crimes."
            });
            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
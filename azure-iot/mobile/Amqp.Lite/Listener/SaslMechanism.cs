﻿//  ------------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation
//  All rights reserved. 
//  
//  Licensed under the Apache License, Version 2.0 (the ""License""); you may not use this 
//  file except in compliance with the License. You may obtain a copy of the License at 
//  http://www.apache.org/licenses/LICENSE-2.0  
//  
//  THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, 
//  EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR 
//  CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, MERCHANTABLITY OR 
//  NON-INFRINGEMENT. 
// 
//  See the Apache Version 2.0 License for specific language governing permissions and 
//  limitations under the License.
//  ------------------------------------------------------------------------------------

namespace Amqp.Listener
{
    using Amqp.Sasl;

    abstract class SaslMechanism
    {
        public abstract string Name { get; }

        public static SaslMechanism External
        {
            get
            {
                return new SaslExternalMechanism();
            }
        }

        public static SaslMechanism Anonymous
        {
            get
            {
                return new SaslExternalMechanism();
            }
        }

        public abstract SaslProfile CreateProfile();

        class SaslExternalMechanism : SaslMechanism
        {
            public override string Name
            {
                get { return SaslProfile.ExternalName; }
            }

            public override SaslProfile CreateProfile()
            {
                return SaslProfile.External;
            }
        }

        class SaslAnonymousMechanism : SaslMechanism
        {
            public override string Name
            {
                get { return SaslProfile.AnonymousName; }
            }

            public override SaslProfile CreateProfile()
            {
                return SaslProfile.Anonymous;
            }
        }
    }
}

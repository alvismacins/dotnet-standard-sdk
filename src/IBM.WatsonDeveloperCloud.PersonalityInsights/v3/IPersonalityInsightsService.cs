﻿/**
* Copyright 2017 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using IBM.WatsonDeveloperCloud.PersonalityInsights.v3.Model;

namespace IBM.WatsonDeveloperCloud.PersonalityInsights.v3
{
    public interface IPersonalityInsightsService
    {
        /// <summary>
        /// Generates a personality profile for the author of the input text. The service accepts a maximum of 20 MB of input content. It can analyze text in Arabic, English, Japanese, or Spanish and return its results in a variety of languages. You can provide plain text, HTML, or JSON input. The service returns output in JSON format by default, but you can request the output in CSV format.
        /// </summary>
        Profile GetProfile(ProfileOptions options);
    }
}
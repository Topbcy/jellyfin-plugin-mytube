<!DOCTYPE html>
<html lang="en">

<head>
    <title>MyTube</title>
</head>

<body>
<div class="page type-interior pluginConfigurationPage MyTubeConfigurationPage" data-require="emby-input,emby-button,emby-select,emby-checkbox,emby-linkbutton" data-role="page">
    <div data-role="content">
        <div class="content-primary">

            <h1>MyTube</h1>

            <div class="readOnlyContent">
                <p class="description1">MyTube Plugin for Jellyfin/Emby. <a class="button-link emby-button" href="https://metatube-community.github.io" is="emby-linkbutton" target="_blank">Learn more</a>.</p>
            </div>

            <form class="MyTubeConfigurationForm">

                <div class="verticalSection">
                    <h2>General</h2>

                    <div class="inputContainer">
                        <label class="inputLabel inputLabelUnfocused" for="txtServer">Server:</label>
                        <input id="txtServer" is="emby-input" name="txtServer" pattern="^https?://.+$" required
                               type="text"/>
                        <div class="fieldDescription">Full url of the MyTube Server, HTTPS protocol is recommended.</div>
                    </div>

                    <div class="inputContainer">
                        <label class="inputLabel inputLabelUnfocused" for="txtToken">Token:</label>
                        <input id="txtToken" is="emby-input" name="txtToken" type="text"/>
                        <div class="fieldDescription">Access token for the MyTube Server, or blank if no token is set by the backend.</div>
                    </div>

                    <div class="checkboxContainer checkboxContainer-withDescription">
                        <label class="emby-checkbox-label">
                            <input id="chkEnableCollections" is="emby-checkbox" name="chkEnableCollections" type="checkbox"/>
                            <span>Enable collections</span>
                        </label>
                        <div class="fieldDescription checkboxFieldDescription">Automatically create collections by series.</div>
                    </div>

                    <div class="checkboxContainer checkboxContainer-withDescription">
                        <label class="emby-checkbox-label">
                            <input id="chkEnableDirectors" is="emby-checkbox" name="chkEnableDirectors" type="checkbox"/>
                            <span>Enable directors</span>
                        </label>
                        <div class="fieldDescription checkboxFieldDescription">Add directors to corresponding video metadata.</div>
                    </div>

                    <div class="checkboxContainer checkboxContainer-withDescription">
                        <label class="emby-checkbox-label">
                            <input id="chkEnableRatings" is="emby-checkbox" name="chkEnableRatings" type="checkbox"/>
                            <span>Enable ratings</span>
                        </label>
                        <div class="fieldDescription checkboxFieldDescription">Display community ratings from the original website.</div>
                    </div>

                    <div class="checkboxContainer checkboxContainer-withDescription">
                        <label class="emby-checkbox-label">
                            <input id="chkEnableTrailers" is="emby-checkbox" name="chkEnableTrailers" type="checkbox"/>
                            <span>Enable trailers</span>
                        </label>
                        <div class="fieldDescription checkboxFieldDescription">Generate online video trailers in strm format.</div>
                    </div>

                    <div class="checkboxContainer checkboxContainer-withDescription">
                        <label class="emby-checkbox-label">
                            <input id="chkEnableRealActorNames" is="emby-checkbox" name="chkEnableRealActorNames" type="checkbox"/>
                            <span>Enable real actor names</span>
                        </label>
                        <div class="fieldDescription checkboxFieldDescription">Search and replace with real actor names from AVBASE.</div>
                    </div>
                </div>

                <div class="verticalSection">
                    <h2 class="sectionTitle">Badge</h2>

                    <div class="checkboxContainer checkboxContainer-withDescription">
                        <label class="emby-checkbox-label">
                            <input id="chkEnableBadges" is="emby-checkbox" name="chkEnableBadges" type="checkbox"/>
                            <span>Enable badges</span>
                        </label>
                        <div class="fieldDescription checkboxFieldDescription">Add Chinese subtitle badges to primary images.</div>
                    </div>

                    <div class="inputContainer">
                        <label class="inputLabel inputLabelUnfocused" for="txtBadgeUrl">Badge url:</label>
                        <input id="txtBadgeUrl" is="emby-input" name="txtBadgeUrl" type="text"/>
                        <div class="fieldDescription">Custom badge url, PNG format is recommended. (default: zimu.png)</div>
                    </div>
                </div>

                <div class="verticalSection">
                    <h2 class="sectionTitle">Image</h2>

                    <div class="inputContainer">
                        <label class="inputLabel inputLabelUnfocused" for="txtPrimaryImageRatio">Primary image ratio:</label>
                        <input id="txtPrimaryImageRatio" is="emby-input" name="txtPrimaryImageRatio" step="any" type="number"/>
                        <div class="fieldDescription">Aspect ratio for primary images, set a negative value to use the default.</div>
                    </div>

                    <div class="inputContainer">
                        <label class="inputLabel inputLabelUnfocused" for="txtDefaultImageQuality">Default image quality:</label>
                        <input id="txtDefaultImageQuality" is="emby-input" max="100" min="0" name="txtDefaultImageQuality" step="1" type="number"/>
                        <div class="fieldDescription">Default compression quality for JPEG images, set between 0 and 100. (default: 90)</div>
                    </div>
                </div>

                <div class="verticalSection">
                    <h2 class="sectionTitle">Provider</h2>

                    <div class="checkboxContainer checkboxContainer-withDescription">
                        <label class="emby-checkbox-label">
                            <input id="chkEnableMovieProviderFilter" is="emby-checkbox" name="chkEnableMovieProviderFilter" type="checkbox"/>
                            <span>Enable movie provider filter</span>
                        </label>
                        <div class="fieldDescription checkboxFieldDescription">Filter and reorder search results from movie providers.</div>
                    </div>

                    <div class="inputContainer">
                        <label class="inputLabel inputLabelUnfocused" for="txtRawMovieProviderFilter">Movie provider filter:</label>
                        <input id="txtRawMovieProviderFilter" is="emby-input" name="txtRawMovieProviderFilter" type="text"/>
                        <div class="fieldDescription">Provider names are case-insensitive, with decreasing precedence from left to right, separated by commas.</div>
                    </div>
                </div>

                <div class="verticalSection">
                    <h2 class="sectionTitle">Template</h2>

                    <div class="checkboxContainer checkboxContainer-withDescription">
                        <label class="emby-checkbox-label">
                            <input id="chkEnableTemplate" is="emby-checkbox" name="chkEnableTemplate" type="checkbox"/>
                            <span>Enable template</span>
                        </label>
                        <div class="fieldDescription checkboxFieldDescription">Predefined template variables can be found <a class="button-link emby-button" href="https://metatube-community.github.io/wiki/text-template/" is="emby-linkbutton" target="_blank">here</a>.</div>
                    </div>

                    <div class="inputContainer">
                        <label class="inputLabel inputLabelUnfocused" for="txtNameTemplate">Name template:</label>
                        <input id="txtNameTemplate" is="emby-input" name="txtNameTemplate" type="text"/>
                        <div class="fieldDescription"></div>
                    </div>

                    <div class="inputContainer">
                        <label class="inputLabel inputLabelUnfocused" for="txtTaglineTemplate">Tagline template:</label>
                        <input id="txtTaglineTemplate" is="emby-input" name="txtTaglineTemplate" type="text"/>
                        <div class="fieldDescription"></div>
                    </div>
                </div>

                <div class="verticalSection">
                    <h2 class="sectionTitle">Translation</h2>

                    <div class="selectContainer">
                        <label class="selectLabel selectLabelText" for="selectTranslationMode">Translation mode:</label>
                        <select class="emby-select-withcolor emby-select selectTranslationMode" id="selectTranslationMode" is="emby-select" name="selectTranslationMode">
                            <option value="Disabled">Disabled</option>
                            <option value="Title">Title</option>
                            <option value="Summary">Summary</option>
                            <option value="Both">Title and Summary</option>
                        </select>
                    </div>

                    <div class="selectTranslationModeEnabled">
                        <div class="selectContainer">
                            <label class="selectLabel selectLabelText" for="selectTranslationEngine">Translation engine:</label>
                            <select class="emby-select-withcolor emby-select selectTranslationEngine" id="selectTranslationEngine" is="emby-select" name="selectTranslationEngine">
                                <option value="Baidu">Baidu</option>
                                <option value="Google">Google</option>
                                <option value="GoogleFree">Google (Free)</option>
                                <option value="DeepL">DeepL (Free)</option>
                                <option value="OpenAi">OpenAI</option>
                            </select>
                        </div>

                        <div class="selectTranslationEngineBaidu">
                            <div class="inputContainer">
                                <label class="inputLabel inputLabelUnfocused" for="txtBaiduAppId">Baidu app id:</label>
                                <input id="txtBaiduAppId" is="emby-input" name="txtBaiduAppId" type="text"/>
                                <div class="fieldDescription"></div>
                            </div>

                            <div class="inputContainer">
                                <label class="inputLabel inputLabelUnfocused" for="txtBaiduAppKey">Baidu app key:</label>
                                <input id="txtBaiduAppKey" is="emby-input" name="txtBaiduAppKey" type="text"/>
                                <div class="fieldDescription"></div>
                            </div>
                        </div>

                        <div class="selectTranslationEngineGoogle">
                            <div class="inputContainer">
                                <label class="inputLabel inputLabelUnfocused" for="txtGoogleApiKey">Google api key:</label>
                                <input id="txtGoogleApiKey" is="emby-input" name="txtGoogleApiKey" type="text"/>
                                <div class="fieldDescription"></div>
                            </div>
                        </div>

                        <div class="selectTranslationEngineDeepL">
                            <div class="inputContainer">
                                <label class="inputLabel inputLabelUnfocused" for="txtDeepLApiKey">DeepL api key:</label>
                                <input id="txtDeepLApiKey" is="emby-input" name="txtDeepLApiKey" type="text"/>
                                <div class="fieldDescription"></div>
                            </div>
                            <div class="inputContainer">
                                <label class="inputLabel inputLabelUnfocused" for="txtDeepLAltUrl">DeepL alt url (optional):</label>
                                <input id="txtDeepLAltUrl" is="emby-input" name="txtDeepLAltUrl" type="text"/>
                                <div class="fieldDescription"></div>
                            </div>
                        </div>

                        <div class="selectTranslationEngineOpenAi">
                            <div class="inputContainer">
                                <label class="inputLabel inputLabelUnfocused" for="txtOpenAiApiKey">OpenAI api key:</label>
                                <input id="txtOpenAiApiKey" is="emby-input" name="txtOpenAiApiKey" type="text"/>
                                <div class="fieldDescription"></div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="verticalSection">
                    <h2 class="sectionTitle">Substitution</h2>

                    <div class="checkboxContainer checkboxContainer-withDescription">
                        <label class="emby-checkbox-label">
                            <input id="chkEnableTitleSubstitution" is="emby-checkbox" name="chkEnableTitleSubstitution" type="checkbox"/>
                            <span>Enable title substitution</span>
                        </label>
                        <div class="fieldDescription checkboxFieldDescription"></div>
                    </div>

                    <div class="inputContainer">
                        <label class="inputLabel inputLabel-float inputLabelUnfocused" for="txtTitleRawSubstitutionTable">Title substitution table:</label>
                        <textarea class="emby-input" id="txtTitleRawSubstitutionTable" is="emby-input" name="txtTitleRawSubstitutionTable" rows="5"></textarea>
                        <div class="fieldDescription">One record per line, separated by equal signs. Leave the target substring blank to delete the source substring.</div>
                    </div>

                    <div class="checkboxContainer checkboxContainer-withDescription">
                        <label class="emby-checkbox-label">
                            <input id="chkEnableActorSubstitution" is="emby-checkbox" name="chkEnableActorSubstitution" type="checkbox"/>
                            <span>Enable actor substitution</span>
                        </label>
                        <div class="fieldDescription checkboxFieldDescription"></div>
                    </div>

                    <div class="inputContainer">
                        <label class="inputLabel inputLabel-float inputLabelUnfocused" for="txtActorRawSubstitutionTable">Actor substitution table:</label>
                        <textarea class="emby-input" id="txtActorRawSubstitutionTable" is="emby-input" name="txtActorRawSubstitutionTable" rows="5"></textarea>
                        <div class="fieldDescription">One record per line, separated by equal signs. Leave the target actor blank to delete the source actor.</div>
                    </div>

                    <div class="checkboxContainer checkboxContainer-withDescription">
                        <label class="emby-checkbox-label">
                            <input id="chkEnableGenreSubstitution" is="emby-checkbox" name="chkEnableGenreSubstitution" type="checkbox"/>
                            <span>Enable genre substitution</span>
                        </label>
                        <div class="fieldDescription checkboxFieldDescription"></div>
                    </div>

                    <div class="inputContainer">
                        <label class="inputLabel inputLabel-float inputLabelUnfocused" for="txtGenreRawSubstitutionTable">Genre substitution table:</label>
                        <textarea class="emby-input" id="txtGenreRawSubstitutionTable" is="emby-input" name="txtGenreRawSubstitutionTable" rows="5"></textarea>
                        <div class="fieldDescription">One record per line, separated by equal signs. Leave the target genre blank to delete the source genre.</div>
                    </div>
                </div>

                <div>
                    <button class="raised button-submit block" is="emby-button" type="submit">
                        <span>Save</span></button>
                </div>

            </form>
        </div>
    </div>
    <script type="text/javascript">
        var MyTubePluginConfig = {
            pluginUniqueId: "2e18517c-b8d9-4117-a937-ce61d9ce3d87"
        };

        $('.selectTranslationMode').on('change', function (_) {
            if (this.value === "Disabled") {
                $('.selectTranslationModeEnabled').css('display', 'none');
            } else {
                $('.selectTranslationModeEnabled').css('display', 'inherit');
            }
        });

        $('.selectTranslationEngine').on('change', function (_) {
            if (this.value === "Baidu") {
                $('.selectTranslationEngineBaidu').css('display', 'inherit');
                $('.selectTranslationEngineGoogle').css('display', 'none');
                $('.selectTranslationEngineDeepL').css('display', 'none');
                $('.selectTranslationEngineOpenAi').css('display', 'none');
            } else if (this.value === "Google") {
                $('.selectTranslationEngineBaidu').css('display', 'none');
                $('.selectTranslationEngineGoogle').css('display', 'inherit');
                $('.selectTranslationEngineDeepL').css('display', 'none');
                $('.selectTranslationEngineOpenAi').css('display', 'none');
            } else if (this.value === "GoogleFree") {
                $('.selectTranslationEngineBaidu').css('display', 'none');
                $('.selectTranslationEngineGoogle').css('display', 'none');
                $('.selectTranslationEngineDeepL').css('display', 'none');
                $('.selectTranslationEngineOpenAi').css('display', 'none');
            } else if (this.value === "DeepL") {
                $('.selectTranslationEngineBaidu').css('display', 'none');
                $('.selectTranslationEngineGoogle').css('display', 'none');
                $('.selectTranslationEngineDeepL').css('display', 'inherit');
                $('.selectTranslationEngineOpenAi').css('display', 'none');
            } else if (this.value === "OpenAi") {
                $('.selectTranslationEngineBaidu').css('display', 'none');
                $('.selectTranslationEngineGoogle').css('display', 'none');
                $('.selectTranslationEngineDeepL').css('display', 'none');
                $('.selectTranslationEngineOpenAi').css('display', 'inherit');
            } else {
                $('.selectTranslationEngineBaidu').css('display', 'none');
                $('.selectTranslationEngineGoogle').css('display', 'none');
                $('.selectTranslationEngineDeepL').css('display', 'none');
                $('.selectTranslationEngineOpenAi').css('display', 'none');
            }
        });

        $('.MyTubeConfigurationPage').on('pageshow', function () {
            Dashboard.showLoadingMsg();
            var page = this;
            ApiClient.getPluginConfiguration(MyTubePluginConfig.pluginUniqueId).then(function (config) {
                $('#txtServer', page).val(config.Server).change();
                $('#txtToken', page).val(config.Token).change();
                page.querySelector('#chkEnableCollections').checked = config.EnableCollections;
                page.querySelector('#chkEnableDirectors').checked = config.EnableDirectors;
                page.querySelector('#chkEnableRatings').checked = config.EnableRatings;
                page.querySelector('#chkEnableTrailers').checked = config.EnableTrailers;
                page.querySelector('#chkEnableRealActorNames').checked = config.EnableRealActorNames;
                page.querySelector('#chkEnableBadges').checked = config.EnableBadges;
                $('#txtBadgeUrl', page).val(config.BadgeUrl).change();
                $('#txtPrimaryImageRatio', page).val(config.PrimaryImageRatio).change();
                $('#txtDefaultImageQuality', page).val(config.DefaultImageQuality).change();
                page.querySelector('#chkEnableMovieProviderFilter').checked = config.EnableMovieProviderFilter;
                $('#txtRawMovieProviderFilter', page).val(config.RawMovieProviderFilter).change();
                page.querySelector('#chkEnableTemplate').checked = config.EnableTemplate;
                $('#txtNameTemplate', page).val(config.NameTemplate).change();
                $('#txtTaglineTemplate', page).val(config.TaglineTemplate).change();
                $('#selectTranslationMode', page).val(config.TranslationMode).change();
                $('#selectTranslationEngine', page).val(config.TranslationEngine).change();
                $('#txtBaiduAppId', page).val(config.BaiduAppId).change();
                $('#txtBaiduAppKey', page).val(config.BaiduAppKey).change();
                $('#txtGoogleApiKey', page).val(config.GoogleApiKey).change();
                $('#txtDeepLApiKey', page).val(config.DeepLApiKey).change();
                $('#txtDeepLAltUrl', page).val(config.DeepLAltUrl).change();
                $('#txtOpenAiApiKey', page).val(config.OpenAiApiKey).change();
                page.querySelector('#chkEnableTitleSubstitution').checked = config.EnableTitleSubstitution;
                $('#txtTitleRawSubstitutionTable', page).val(config.TitleRawSubstitutionTable).change();
                page.querySelector('#chkEnableActorSubstitution').checked = config.EnableActorSubstitution;
                $('#txtActorRawSubstitutionTable', page).val(config.ActorRawSubstitutionTable).change();
                page.querySelector('#chkEnableGenreSubstitution').checked = config.EnableGenreSubstitution;
                $('#txtGenreRawSubstitutionTable', page).val(config.GenreRawSubstitutionTable).change();
                Dashboard.hideLoadingMsg();
            });
        });

        $('.MyTubeConfigurationForm').on('submit', function () {
            Dashboard.showLoadingMsg();
            var form = this;
            ApiClient.getPluginConfiguration(MyTubePluginConfig.pluginUniqueId).then(function (config) {
                config.Server = $('#txtServer', form).val();
                config.Token = $('#txtToken', form).val();
                config.EnableCollections = $('#chkEnableCollections', form).prop('checked');
                config.EnableDirectors = $('#chkEnableDirectors', form).prop('checked');
                config.EnableRatings = $('#chkEnableRatings', form).prop('checked');
                config.EnableTrailers = $('#chkEnableTrailers', form).prop('checked');
                config.EnableRealActorNames = $('#chkEnableRealActorNames', form).prop('checked');
                config.EnableBadges = $('#chkEnableBadges', form).prop('checked');
                config.BadgeUrl = $('#txtBadgeUrl', form).val();
                config.PrimaryImageRatio = $('#txtPrimaryImageRatio', form).val();
                config.DefaultImageQuality = $('#txtDefaultImageQuality', form).val();
                config.EnableMovieProviderFilter = $('#chkEnableMovieProviderFilter', form).prop('checked');
                config.RawMovieProviderFilter = $('#txtRawMovieProviderFilter', form).val();
                config.EnableTemplate = $('#chkEnableTemplate', form).prop('checked');
                config.NameTemplate = $('#txtNameTemplate', form).val();
                config.TaglineTemplate = $('#txtTaglineTemplate', form).val();
                config.TranslationMode = $('#selectTranslationMode', form).val();
                config.TranslationEngine = $('#selectTranslationEngine', form).val();
                config.BaiduAppId = $('#txtBaiduAppId', form).val();
                config.BaiduAppKey = $('#txtBaiduAppKey', form).val();
                config.GoogleApiKey = $('#txtGoogleApiKey', form).val();
                config.DeepLApiKey = $('#txtDeepLApiKey', form).val();
                config.DeepLXAltUrl = $('#txtDeepLAltUrl', form).val();
                config.OpenAiApiKey = $('#txtOpenAiApiKey', form).val();
                config.EnableTitleSubstitution = $('#chkEnableTitleSubstitution', form).prop('checked');
                config.TitleRawSubstitutionTable = $('#txtTitleRawSubstitutionTable', form).val();
                config.EnableActorSubstitution = $('#chkEnableActorSubstitution', form).prop('checked');
                config.ActorRawSubstitutionTable = $('#txtActorRawSubstitutionTable', form).val();
                config.EnableGenreSubstitution = $('#chkEnableGenreSubstitution', form).prop('checked');
                config.GenreRawSubstitutionTable = $('#txtGenreRawSubstitutionTable', form).val();
                ApiClient.updatePluginConfiguration(MyTubePluginConfig.pluginUniqueId, config).then(Dashboard.processPluginConfigurationUpdateResult);
            });
            // Disable default form submission
            return false;
        });
    </script>
</div>
</body>
</html>

namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsPollyVoicesState = { assignments: ResizeArray<aws.DataAwsPollyVoices.DataAwsPollyVoicesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/polly_voices">aws_polly_voices</a>.
    /// </summary>
    type DataAwsPollyVoicesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsPollyVoicesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsPollyVoicesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/polly_voices#engine-1">DataAwsPollyVoices#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: DataAwsPollyVoicesState, value: string) : DataAwsPollyVoicesState =
            state.assignments.Add(fun config -> config.Engine <- value)
            state : DataAwsPollyVoicesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/polly_voices#include_additional_language_codes-1">DataAwsPollyVoices#include_additional_language_codes</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_additional_language_codes">]
        member _.IncludeAdditionalLanguageCodes(state: DataAwsPollyVoicesState, value: bool) : DataAwsPollyVoicesState =
            state.assignments.Add(fun config -> config.IncludeAdditionalLanguageCodes <- value)
            state : DataAwsPollyVoicesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/polly_voices#include_additional_language_codes-1">DataAwsPollyVoices#include_additional_language_codes</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_additional_language_codes">]
        member _.IncludeAdditionalLanguageCodes(state: DataAwsPollyVoicesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsPollyVoicesState =
            state.assignments.Add(fun config -> config.IncludeAdditionalLanguageCodes <- value)
            state : DataAwsPollyVoicesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/polly_voices#language_code-1">DataAwsPollyVoices#language_code</a>.
        /// </summary>
        [<CustomOperation "language_code">]
        member _.LanguageCode(state: DataAwsPollyVoicesState, value: string) : DataAwsPollyVoicesState =
            state.assignments.Add(fun config -> config.LanguageCode <- value)
            state : DataAwsPollyVoicesState

        /// <summary>
        /// voices block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/polly_voices#voices-1">DataAwsPollyVoices#voices</a> Accepts: aws.IResolvable | aws.DataAwsPollyVoices.DataAwsPollyVoicesVoices[]
        /// </summary>
        [<CustomOperation "voices">]
        member _.Voices(state: DataAwsPollyVoicesState, value: HashiCorp.Cdktf.IResolvable) : DataAwsPollyVoicesState =
            state.assignments.Add(fun config -> config.Voices <- value)
            state : DataAwsPollyVoicesState

        member _.Run(state: DataAwsPollyVoicesState) : aws.DataAwsPollyVoices.DataAwsPollyVoices =
            let config = aws.DataAwsPollyVoices.DataAwsPollyVoicesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsPollyVoices.DataAwsPollyVoices(StackContext.get (), logicalId, config)

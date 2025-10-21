namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueClassifierState<'Name> = { assignments: ResizeArray<aws.GlueClassifier.GlueClassifierConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier">aws_glue_classifier</a>.
    /// </summary>
    type GlueClassifierBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueClassifierState<Missing> =
            ({ assignments = ResizeArray() } : GlueClassifierState<Missing>)

        member _.Zero(()) : GlueClassifierState<Missing> =
            ({ assignments = ResizeArray() } : GlueClassifierState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#name-1">GlueClassifier#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueClassifierState<Missing>, value: string) : GlueClassifierState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueClassifierState<Present>)

        /// <summary>
        /// csv_classifier block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#csv_classifier-1">GlueClassifier#csv_classifier</a>
        /// </summary>
        [<CustomOperation "csv_classifier">]
        member _.CsvClassifier(state: GlueClassifierState<'Name>, value: aws.GlueClassifier.GlueClassifierCsvClassifier) : GlueClassifierState<'Name> =
            state.assignments.Add(fun config -> config.CsvClassifier <- value)
            state : GlueClassifierState<'Name>

        /// <summary>
        /// grok_classifier block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#grok_classifier-1">GlueClassifier#grok_classifier</a>
        /// </summary>
        [<CustomOperation "grok_classifier">]
        member _.GrokClassifier(state: GlueClassifierState<'Name>, value: aws.GlueClassifier.GlueClassifierGrokClassifier) : GlueClassifierState<'Name> =
            state.assignments.Add(fun config -> config.GrokClassifier <- value)
            state : GlueClassifierState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#id-1">GlueClassifier#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueClassifierState<'Name>, value: string) : GlueClassifierState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueClassifierState<'Name>

        /// <summary>
        /// json_classifier block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#json_classifier-1">GlueClassifier#json_classifier</a>
        /// </summary>
        [<CustomOperation "json_classifier">]
        member _.JsonClassifier(state: GlueClassifierState<'Name>, value: aws.GlueClassifier.GlueClassifierJsonClassifier) : GlueClassifierState<'Name> =
            state.assignments.Add(fun config -> config.JsonClassifier <- value)
            state : GlueClassifierState<'Name>

        /// <summary>
        /// xml_classifier block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_classifier#xml_classifier-1">GlueClassifier#xml_classifier</a>
        /// </summary>
        [<CustomOperation "xml_classifier">]
        member _.XmlClassifier(state: GlueClassifierState<'Name>, value: aws.GlueClassifier.GlueClassifierXmlClassifier) : GlueClassifierState<'Name> =
            state.assignments.Add(fun config -> config.XmlClassifier <- value)
            state : GlueClassifierState<'Name>

        member _.Run(state: GlueClassifierState<Present>) : aws.GlueClassifier.GlueClassifier =
            let config = aws.GlueClassifier.GlueClassifierConfig()
            for setter in state.assignments do
                setter config
            aws.GlueClassifier.GlueClassifier(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueClassifier: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: GlueClassifierState<_>) : aws.GlueClassifier.GlueClassifier =
            Unchecked.defaultof<aws.GlueClassifier.GlueClassifier>

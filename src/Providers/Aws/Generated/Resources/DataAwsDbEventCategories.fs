namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDbEventCategoriesState = { assignments: ResizeArray<aws.DataAwsDbEventCategories.DataAwsDbEventCategoriesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_event_categories">aws_db_event_categories</a>.
    /// </summary>
    type DataAwsDbEventCategoriesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDbEventCategoriesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsDbEventCategoriesState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_event_categories#id-1">DataAwsDbEventCategories#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDbEventCategoriesState, value: string) : DataAwsDbEventCategoriesState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsDbEventCategoriesState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/db_event_categories#source_type-1">DataAwsDbEventCategories#source_type</a>.
        /// </summary>
        [<CustomOperation "source_type">]
        member _.SourceType(state: DataAwsDbEventCategoriesState, value: string) : DataAwsDbEventCategoriesState =
            state.assignments.Add(fun config -> config.SourceType <- value)
            state : DataAwsDbEventCategoriesState

        member _.Run(state: DataAwsDbEventCategoriesState) : aws.DataAwsDbEventCategories.DataAwsDbEventCategories =
            let config = aws.DataAwsDbEventCategories.DataAwsDbEventCategoriesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDbEventCategories.DataAwsDbEventCategories(StackContext.get (), logicalId, config)

declare module 'vuetify/lib' {
  import 'vuetify/types'
  import Vue from 'vue'
  const Vuetify: Vue.PluginObject<any>
  export default Vuetify
}

declare module 'vuetify/lib/util/colors' {
  const colors: any
  export default colors
}

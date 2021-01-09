<template>
  <div id="app">
    <div class="vuex-test">
      <h1>Stored Number {{safelyStoredNumber}}</h1>
      <button v-on:click="incrementStoredNumber(safelyStoredNumber)">Up</button>
      <button v-on:click="decreaseStoredNumber(safelyStoredNumber,numberNine)">Down</button>
    </div>
    <demo-ref>
      <div class="slot-demo">
        <component-tabs title="Tiêu đề của Tabs" />
      </div>
    </demo-ref>
    <div class="container">
      <button v-on:click="msg='Hello World Vue Vue Vue'">Thay đổi title từ Component App.vue</button>
      <component-header v-bind:title="titleHeader" v-on:handleHeaderEvent="changeTitle" />
      <h1>{{ msg }}</h1>
      <list-user v-bind:listUser="listUser" v-on:HandleDelete="DeleteStored" />
    </div>
  </div>
</template>

<script>
import ComponentHeader from "./components/ComponentHeader.vue";
import ListUser from "./components/ListUser.vue";
import DemoRef from "./components/DemoRef.vue";
import ComponentTabs from "./components/ComponentTabs.vue";
import { mapGetters, mapMutations } from "vuex";
export default {
  name: "app",
  data() {
    return {
      msg: "Welcome to Your Vue.js App",
      titleHeader: "WELCOME TO HEADER",
      listUser: [
        { email: "test1@gmail.com", active: true },
        { email: "test2@gmail.com", active: true },
        { email: "test3@gmail.com", active: false },
        { email: "test4@gmail.com", active: false },
        { email: "test5@gmail.com", active: true },
        { email: "test6@gmail.com", active: false },
        { email: "test7@gmail.com", active: false }
      ],
      numberNine: 9
    };
  },
  components: {
    ComponentHeader,
    ListUser,
    DemoRef,
    ComponentTabs
  },
  methods: {
    changeTitle() {
      console.log("Tui sẽ thay đổi từ header");
      return (this.msg = "Vivien");
    },
    HandleDelete(email) {
      console.log("App Called");
      var indexDel = -1;
      this.listUser.forEach((user, index) => {
        if (user.email === email) {
          indexDel = index;
        }
      });
      if (indexDel != -1) {
        this.listUser.splice(indexDel, 1);
      }
    },
    ...mapMutations([
      "incrementStoredNumber",
      "decreaseStoredNumber",
      "setStoredNumber"
    ]),
  },
  computed: {
    ...mapGetters(["safelyStoredNumber"])
  }
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
.container {
  max-width: 1170px;
  margin: 0 auto;
  padding: 0 15px;
  min-height: 3000px;
}
</style>

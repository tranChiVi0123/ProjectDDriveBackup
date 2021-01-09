<template>
  <div class="demo-ref">
    <h1>DemoRef</h1>
    <button class="avatar" v-on:click="HandleClickInputFile">Thay đổi AVATAR</button>
    <input ref="fileInputAvatar" style="display:none" type="file" />
    <slot />
    <ul class="tabs-header">
      <li
        v-for="(item,index) in tabsHeader"
        v-bind:key="index"
        v-on:click="SetActiveTab(index)"
        v-bind:class="{active: tabActive==index}"
      >{{item.text}}</li>
    </ul>
    <div class="tabs-content tab1" v-if="tabActive==0">
      <h1>Tab 1</h1>
      <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Alias sunt culpa commodi. Soluta sapiente vel saepe assumenda eligendi omnis? Facere ut pariatur, vero ex fuga cum! Culpa atque quod nesciunt?</p>
    </div>
    <div class="tabs-content tab2" v-if="tabActive==1">
      <h1>Tab 2</h1>
      <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Alias sunt culpa commodi. Soluta sapiente vel saepe assumenda eligendi omnis? Facere ut pariatur, vero ex fuga cum! Culpa atque quod nesciunt?</p>
    </div>
    <div class="tabs-content tab3" v-if="tabActive==2">
      <h1>Tab 3</h1>
      <p>Lorem ipsum dolor, sit amet consectetur adipisicing elit. Alias sunt culpa commodi. Soluta sapiente vel saepe assumenda eligendi omnis? Facere ut pariatur, vero ex fuga cum! Culpa atque quod nesciunt?</p>
    </div>
  </div>
</template>

<script>
export default {
  name: "demo-ref",
  data() {
    return {
      tabsHeader: [{ text: "Tab1" }, { text: "Tab2" }, { text: "Tab3" }],
      tabActive: 0
    };
  },
  methods: {
    HandleClickInputFile(e) {
      this.$refs.fileInputAvatar.click();
    },
    SetActiveTab(index) {
      this.tabActive = index;
    }
  }
};
</script>

<style>
.demo-ref {
  margin-top: 10px;
  padding: 100px 30px;
  border: 1px solid pink;
}
.avatar {
  padding: 12px 15px;
  color: #fff;
  border: 2px solid #333;
  background-color: orange;
}
.avatar:hover {
  color: powderblue;
  background-color: gray;
}
</style>